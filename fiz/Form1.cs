using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;

namespace FizHelp
{


    public partial class Form1 : Form
    {
        Kerdesek Klista;
        Valaszok Vlista;

        Random rnd = new Random();
        int flagV = -1;
        int flagK = -1;
        int counter = 3;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(flagV);
            label1.Text = Convert.ToString(flagK);
            if (flagV == flagK)
            {
                counter--;
                if (counter == 0)
                {
                    button3.Visible = true;
                    counter = 3;

                }
                else
                {
                    KCUpdate();
                }
            }
            else
            {
                KCUpdate();
            }
        }


        private void KCUpdate()
        {
            cardupdateV();
            cardupdateK();
        }
        private void cardupdateK()
        {
            int flagNewK;
            do
            {
                flagNewK = random();
            } while (flagK == flagNewK);
            flagK = flagNewK;
            pictureBox1.Image = Image.FromFile(Klista.getKerdes(flagK));

        }
        private void cardupdateV()
        {
            int flagNew;
            do
            {
                flagNew = random();
            } while (flagV == flagNew);
            flagV = flagNew;
            pictureBox2.Image = Image.FromFile(Vlista.getV(flagV));
        }

        private int random()
        {
            return rnd.Next(0, Klista.getKL());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cardupdateV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Fizika kérdések";
            button3.Visible = false;
            Vlista = new Valaszok();
            Klista = new Kerdesek();
            KCUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Klista = new Kerdesek();
            Vlista = new Valaszok();
            KCUpdate();
        }
    }
}
