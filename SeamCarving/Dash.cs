using System;
using System.Drawing;
using System.Windows.Forms;

namespace SeamCarving
{
    public partial class Dash : Form
    {
        DirectBitmap image;
        public Dash()
        {
            InitializeComponent();
        }

        private void btn_selectImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new DirectBitmap(dialog.FileName);
                pbox_original.Image = image.Bitmap;
                num_width.Value = image.Width;
                num_height.Value = image.Height;
                btn_perform.Enabled = true;
                btn_save.Enabled = true;
                btn_startEdge.Enabled = true;
                num_height.Enabled = true;
                num_width.Enabled = true;
            }

        }
        bool showingEdges = false;
        private void btn_startEdge_Click(object sender, EventArgs e)
        {

            pbox_original.Image = showingEdges? image.Bitmap : EdgeDetector.GetEdgeImage(image).Bitmap;
            showingEdges = !showingEdges;
        }

        private void btn_perform_Click(object sender, EventArgs e)
        {
            var resized = Carver.ResizeCarving(image,new Size((int)num_width.Value,(int)num_height.Value));
            this.pbox_original.Image = resized.Bitmap;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var saver = new SaveFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };
            if (saver.ShowDialog() == DialogResult.OK)
            {
                pbox_original.Image.Save(saver.FileName);
            }
        }

        private void Dash_Load(object sender, EventArgs e)
        {

        }
    }
}
