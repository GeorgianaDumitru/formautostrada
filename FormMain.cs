using Autostrazi;

namespace Proiect
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void autostraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormAutostrada();
            f.MdiParent = this;
            f.Show();
        }

        private void inLucruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormInLucru();
            f.MdiParent = this;
            f.Show();
        }
    }
}