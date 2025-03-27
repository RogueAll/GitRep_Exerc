namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GlobVar.rotatorointaor=270;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GlobVar.rotatorointaor=180;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GlobVar.rotatorointaor=90;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
