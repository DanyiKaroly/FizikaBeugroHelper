using fiz;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;

namespace FizHelp
{


    public partial class GameForm1 : Form
    {
        Valaszok Valaszlista = new Valaszok();
        Kerdesek KerdesLista = new Kerdesek();
        List<PictureBox> buttons = new List<PictureBox>();

        int flagK = -1;
        int counter = 10;
        public GameForm1()
        {
            Valaszlista.feltoltV();
            InitializeComponent();

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
            if (pictureBox1.Height < KerdesLista.getKerdes(flagK).Height || pictureBox1.Width < KerdesLista.getKerdes(flagK).Width)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            pictureBox1.Image = KerdesLista.getKerdes(flagK);
        }
        private void cardupdateV()
        {
            for (int k = 0; k < Valaszlista.getVL(); k++)
            {
                PictureBox newButton = new PictureBox();
                newButton.BackColor = Color.White;
                int currentK = k;
                newButton.Click += (s, e) => { ellenorzo(Valaszlista.getID(currentK)); };
                newButton.Size = new Size(959, 99);
                newButton.Location = new Point(0, k * (100));
                if (newButton.Height < Valaszlista.getV(k).Height || newButton.Width < Valaszlista.getV(k).Width)
                    newButton.SizeMode = PictureBoxSizeMode.Zoom;
                else
                    newButton.SizeMode = PictureBoxSizeMode.CenterImage;
                

                newButton.Image = Valaszlista.getV(k);
                buttons.Add(newButton);
                panel1.Controls.Add(newButton);
            }
        }
        private void ellenorzo(int szamol)
        {
            if (KerdesLista.getID(flagK) == szamol)
            {
                label1.Text = "Helyes!";
                pictureBox3.BackColor = Color.Green;
                animator.Start();
                KerdesLista.removeK(flagK);
                counter--;
                if (counter == 0)
                {
                    for (int i = 0; i < buttons.Count; i++)
                    {
                        buttons[i].Enabled = false;
                    }
                    animator.Stop();
                    pictureBox3.BackColor = Color.Transparent;
                    label1.Text = "Teljesítetted a gyakorlást!";
                    button3.Visible = true;
                }
                else
                {
                    cardupdateK();
                }
            }
            else
            {
                label1.Text = "Helytelen!";
                pictureBox3.BackColor = Color.Red;
                animator.Start();
                cardupdateK();
            }
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



        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Enabled = true;
            }
            listain();
            label1.Text = "Fizika kérdések";
            button3.Visible = false;
            cardupdateK();
            counter = KerdesLista.getKL();
            label1.Text = "Válassz!";
        }
        private void listain()
        {
            KerdesLista = new Kerdesek();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            counter = KerdesLista.getKL();
            listain();
            cardupdateK();
            cardupdateV();

        }

        private void animator_Tick(object sender, EventArgs e)
        {
            label1.Text = "Válassz!";
            pictureBox3.BackColor = Color.Transparent;
            animator.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
            listain();
            cardupdateK();
            this.Hide();
        }

    }
}
