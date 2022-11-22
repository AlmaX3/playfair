using System.Diagnostics;
using System.Linq;

namespace playfairGUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] KarakterParok = richTextBox1.Text.Split(" ");
            if (KarakterParok.Any(x => x.Length != 2))
            {
                label1.ForeColor = Color.DarkRed;
            }
            else if (KarakterParok.Any(x => (Char.IsLower(x[0]) || Char.IsLower(x[1]))))
            {
                label1.ForeColor = Color.DarkBlue;
            }
            else if (KarakterParok.Any(x => x[0] == x[1]))
            {
                label1.ForeColor = Color.Magenta;
            } else
            {
                label1.ForeColor = Color.DarkGreen;
            }


        }
    }
}