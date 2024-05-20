using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;

namespace FizHelp
{


    public partial class Form1 : Form
    {


        Valaszok Valaszlista = new Valaszok();
        Kerdesek KerdesLista = new Kerdesek();

        int flagV = -1;
        int flagK = -1;
        int counter = 3;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (flagV == flagK)
            {
                label1.Text = "Helyes!";
                pictureBox3.BackColor = Color.Green;
                animator.Start();
                counter--;
                KerdesLista.removeK(flagK);
                Valaszlista.removeV(flagV);

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
                label1.Text = "Helytelen!";
                pictureBox3.BackColor = Color.Red;
                animator.Start();
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
            int flagNewK = flagK;

            if (KerdesLista.getKL() != 1)
            {

                while (flagNewK == flagK)
                {
                    flagNewK = random();
                }
            }
            else flagNewK = 0;
            flagK = flagNewK;
            pictureBox1.Image = Image.FromFile(KerdesLista.getKerdes(flagK));

        }
        private void cardupdateV()
        {
            int flagNew = flagV;
            if (Valaszlista.getVL() != 1)
            {
                while (flagV == flagNew)
                {
                    flagNew = random();
                }
            }
            else flagNew = 0;

            flagV = flagNew;
            pictureBox2.Image = Image.FromFile(Valaszlista.getV(flagV));
        }

        private int random()
        {
            Random rnd = new Random();
            return rnd.Next(0, KerdesLista.getKL());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cardupdateV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listain();
            label1.Text = "Fizika kérdések";
            button3.Visible = false;
            KCUpdate();
        }
        private void listain()
        {
            Valaszlista = new Valaszok();
            KerdesLista = new Kerdesek();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KCUpdate();
        }

        private void animator_Tick(object sender, EventArgs e)
        {
            label1.Text = "Válassz!";
            pictureBox3.BackColor = Color.Gainsboro;
            animator.Stop();
        }
    }
}
