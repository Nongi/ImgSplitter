using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgSplitter
{
    public partial class ImgSplitter : Form
    {
        public ImgSplitter()
        {
            InitializeComponent();
        }

        private void ImgSplitter_Load(object sender, EventArgs e)
        {
        }

        public void split_img(string filePath, int width, int height)
        {

            try
            {
                DirectoryInfo di = Directory.CreateDirectory(String.Concat(Path.GetDirectoryName(filePath), "\\", Path.GetFileNameWithoutExtension(filePath)));

                Console.WriteLine(di.FullName);

                Bitmap img_source = (Bitmap)Image.FromFile(filePath, true);

                for (int i = 0; i < img_source.Height / height; i++)
                {
                    for (int j = 0; j < img_source.Width / width; j++)
                    {
                        Rectangle cloneRect = new Rectangle(
                            i * width,
                            j * height,
                            width,
                            height);

                        System.Drawing.Imaging.PixelFormat format = img_source.PixelFormat;
                        Bitmap cloneBitmap = img_source.Clone(cloneRect, format);

                        cloneBitmap.Save(
                            Path.Combine(
                                di.FullName,
                                Path.GetFileNameWithoutExtension(filePath) + "_" + i + "_" + j + ".png"
                            )
                        );

                    }
                }


                Console.ReadLine();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("There was an error opening the bitmap." +
                    "Please check the path.");
            }
        }

        private void bt_split_Click(object sender, EventArgs e)
        {
            var filePath = tb_filePath.Text;
            var width = Int32.Parse(tb_Width.Text);
            var height = Int32.Parse(tb_Height.Text);

            split_img(filePath, width, height);
            MessageBox.Show("Split terminé");
        }

        private void bt_choosePath_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "Image Files (.png)|*.png|Image Files (.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_filePath.Text = openFileDialog1.FileName;
            }
        }
    }
}
