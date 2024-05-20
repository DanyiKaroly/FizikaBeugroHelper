using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;

namespace FizHelp
{
    public partial class Form1 : Form
    {
        MenuForm menuform = new MenuForm();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            menuform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
