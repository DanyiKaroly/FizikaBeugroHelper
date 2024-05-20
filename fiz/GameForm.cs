using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;

namespace FizHelp
{


    public partial class MenuForm : Form
    {


        Valaszok Valaszlista = new Valaszok();
        Kerdesek KerdesLista = new Kerdesek();
        Valaszok ValaszlistaMent = new Valaszok();

        int flagV = -1;
        int flagK = -1;
        int counter = 10;
        public MenuForm()
        {
            Valaszlista.feltoltV();
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (KerdesLista.getID(flagK) == Valaszlista.getID(flagV))
            {
                label1.Text = "Helyes!";
                pictureBox3.BackColor = Color.Green;
                animator.Start();
                ValaszlistaMent.addV(Valaszlista.getID(flagV),Valaszlista.getV(flagV));
                KerdesLista.removeK(flagK);
                Valaszlista.removeV(flagV);
                counter--;
                if (counter == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Visible = true;
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
                    flagNewK = randomK();
                }
            }
            else flagNewK = 0;
            flagK = flagNewK;
            if(pictureBox1.Height < KerdesLista.getKerdes(flagK).Height|| pictureBox1.Width < KerdesLista.getKerdes(flagK).Width)
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            pictureBox1.Image = KerdesLista.getKerdes(flagK);
        }
        private bool hasznaltValasz()
        {
            int volt = 0;
                for (int j = 0; j < ValaszlistaMent.getVL(); j++)
                {
                    if (ValaszlistaMent.getID(j) == Valaszlista.getID(flagV))
                    {
                        volt = 1;
                        return true;
                    }
                }
            return false;
        }
        private void cardupdateV()
        {
            int flagNew = flagV;
            do
            {
            if (Valaszlista.getVL() != 1)
            {
                while (flagV == flagNew)
                {
                    flagNew = randomV();
                }
            }
            else flagNew = 0;
            flagV = flagNew;
            } while (hasznaltValasz()==true);


            if (pictureBox2.Height < Valaszlista.getV(flagV).Height || pictureBox2.Width < Valaszlista.getV(flagV).Width)
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;


            pictureBox2.Image = Valaszlista.getV(flagV);
        }

        private int randomK()
        {
            Random rnd = new Random();
            return rnd.Next(0, KerdesLista.getKL());
        }
        private int randomV()
        {
            Random rnd = new Random();
            return rnd.Next(0, Valaszlista.getVL());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Valaszlista.getVL() <= 1)
                if(ValaszlistaMent.getVL()==0)
                Valaszlista = ValaszlistaMent;
            else
                Valaszlista.removeV(flagV);
            cardupdateV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listain();
            label1.Text = "Fizika kérdések";
            button3.Visible = false;
            KCUpdate();
            button1.Enabled = true;
            button2.Enabled = true;
            counter = KerdesLista.getKL();

        }
        private void listain()
        {
            Valaszlista.feltoltV();
            KerdesLista = new Kerdesek();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            counter = KerdesLista.getKL();
            listain();
            KCUpdate();
        }

        private void animator_Tick(object sender, EventArgs e)
        {
            label1.Text = "Válassz!";
            pictureBox3.BackColor = Color.Transparent;
            animator.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ValaszlistaMent = new Valaszok();
            listain();
            KCUpdate();
            this.Hide();
        }
    }
}
