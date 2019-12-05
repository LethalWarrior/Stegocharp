using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Steganography.Classes;

namespace Steganography
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            CbxOperation.SelectedItem = CbxOperation.Items[0];
        }
        

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Files (*.BMP)|*.bmp|PNG (*.PNG)|*.png";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                TbxPath.Text = ofd.FileName;
                MainPb.Image = Image.FromFile(ofd.FileName);
            }
            
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (CbxOperation.SelectedItem == CbxOperation.Items[0]) EncryptMessage();
            else DecryptMessage();
        }

        private void CbxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbxOperation.SelectedIndex == 1)
            {
                TbxMessage.Clear();
                TbxMessage.Enabled = false;
            }
            else TbxMessage.Enabled = true;
        }

        #endregion

        #region Methods
        private void EncryptMessage()
        {
            Bitmap img = new Bitmap(TbxPath.Text);

            int width = img.Width;
            int height = img.Height;

            //Convert image to list of RGB bytes
            List<string> bytesOfPixels = Helper.ConvertImageToPixelRGBs(img);
            //Convert message to bytes
            List<string> bytesOfMessage = Helper.ConvertTextToBytes(TbxMessage.Text);
            //Convert message length to bytes (must be < 256)
            string byteOfMessageLength = Convert.ToString(TbxMessage.TextLength, 2).PadLeft(8, '0');

            List<int> ReplacedElementsIndex = new List<int>();

            //Measuring the amount of the bytes that will be replaced
            int targetBytesAmount = (TbxMessage.Text.Length * 8) / 2 + 4;

            //Loop through the message length bytes
            for (int i = 0; i < byteOfMessageLength.Length; i++)
            {
                //Skip two by two, eg: 0,1 2,3
                if (i % 2 == 0)
                {
                    for (int x = 0; x < 4; x++)
                    {
                        //Skip if element was replaced
                        if (ReplacedElementsIndex.Contains(x) == false)
                        {
                            var chars = bytesOfPixels[x].ToCharArray();
                            chars[6] = byteOfMessageLength[i];
                            chars[7] = byteOfMessageLength[i + 1];
                            bytesOfPixels[x] = new string(chars);

                            ReplacedElementsIndex.Add(x);
                            break;
                        }
                    }
                }
            }

            //Loop through the message characters
            for (int i = 0; i < bytesOfMessage.Count; i++)
            {
                //Loop through the bit
                for (int j = 0; j < bytesOfMessage[i].Length; j++)
                {
                    //Skip two by two, eg: 0,1 2,3
                    if (j % 2 == 0)
                    {
                        //index from 4 because index 0 already filled by length info
                        for (int x = 4; x < targetBytesAmount; x++)
                        {
                            //Skip if element was replaced
                            if (ReplacedElementsIndex.Contains(x) == false)
                            {
                                var chars = bytesOfPixels[x].ToCharArray();
                                chars[6] = bytesOfMessage[i][j];
                                chars[7] = bytesOfMessage[i][j + 1];
                                bytesOfPixels[x] = new string(chars);

                                ReplacedElementsIndex.Add(x);
                                break;
                            }
                        }
                    }
                }
            }

            //Repack the bytes into pixels
            List<Color> pixels = new List<Color>();

            for (int i = 0; i < bytesOfPixels.Count; i++)
            {
                if (i % 3 == 0)
                {
                    pixels.Add(System.Drawing.Color.FromArgb(
                        Convert.ToInt32(bytesOfPixels[i], 2),
                        Convert.ToInt32(bytesOfPixels[i + 1], 2),
                        Convert.ToInt32(bytesOfPixels[i + 2], 2)));
                }
            }

            //Create new image from pixels 
            Bitmap bitmap = new Bitmap(width, height);
            int row = 0, column = 0;
            for (int i = 0; i < pixels.Count; ++i)
            {
                bitmap.SetPixel(row, column, pixels[i]);
                column++;
                if (column == width)
                {
                    column = 0;
                    row++;
                }

            }

            //Save new image
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Files (*.BMP)|*.bmp|PNG (*.PNG)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(sfd.FileName);
            }

            MessageBox.Show("Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DecryptMessage()
        {
            Bitmap img = new Bitmap(TbxPath.Text);

            //Convert image to list of RGB bytes
            List<string> bytesOfPixels = Helper.ConvertImageToPixelRGBs(img);

            //Get message length
            string messageLengthByte = "";

            for (int i = 0; i < 4; i++)
            {
                messageLengthByte += bytesOfPixels[i][6];
                messageLengthByte += bytesOfPixels[i][7];
            }

            int messageLength = Convert.ToInt32(messageLengthByte, 2);

            //Measuring the amount of the bytes that will be read
            int targetBytesAmount = (messageLength * 8) / 2 + 4;

            //Get message in binary, starts from 4 because the first 4 element is only the info
            string binarymessage = "";
            int count = 0;
            for (int i = 4; i < targetBytesAmount; i++)
            {
                if (count == 4)
                {
                    count = 0;
                    binarymessage += ' ';
                }
                binarymessage += bytesOfPixels[i][6];
                binarymessage += bytesOfPixels[i][7];
                count++;
            }

            //Get real message
            string[] binarycharacters = binarymessage.Split(' ');
            string result = "";
            for (int i = 0; i < binarycharacters.Length; i++)
            {
                result += (char)Convert.ToInt32(binarycharacters[i], 2);
            }

            MessageBox.Show("Hidden message: " + result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TbxMessage.Text = result;

        }
        #endregion
    }
}
