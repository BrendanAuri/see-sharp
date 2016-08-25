using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFun
{
    public partial class Interface : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = 625;
            int h = 411;
            Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            Size = new Size(w, h);
             //base.OnPaint(e);
        }
        public void initializeGraphics() {
            Graphics g = panel1.CreateGraphics();
            
        }
        public Interface()
        {
            InitializeComponent();
            initializeGraphics();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG files | *.png";
            openFileDialog1.ShowDialog();
            imageTextbox.Text = openFileDialog1.FileName;
            Graphics g = panel1.CreateGraphics();
            Image imageToLoad = Image.FromFile(imageTextbox.Text);
            g.DrawImage(imageToLoad, panel1.Bounds, 0, 0, imageToLoad.Width, imageToLoad.Height, GraphicsUnit.Pixel);
        }

        private void 

        private void insertItemPropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
