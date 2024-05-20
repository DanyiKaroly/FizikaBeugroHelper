using fiz;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;

namespace FizHelp
{


    public partial class ElesForm : Form
    {
        Valaszok Valaszlista = new Valaszok();
        Kerdesek KerdesLista = new Kerdesek();
        List<PictureBox> buttons = new List<PictureBox>();

        int flagK = -1;
        int counter = 10;
        int hiba = 0;
        public ElesForm()
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
                    KerdesLista.removeK(flagK);
                    label1.Text = "Helyes!";
                    pictureBox3.BackColor = Color.Green;
                    animator.Start();
                }
                else
                {
                    hiba++;
                    KerdesLista.removeK(flagK);
                    label1.Text = "Helytelen!";
                    pictureBox3.BackColor = Color.Red;
                    animator.Start();
                }
                counter--;
            if(counter==0)
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].Enabled = false;
                }
                animator.Stop();
                label1.Text = "Teljesítetted a beugrót!\nHiba: " + hiba;
                button3.Visible = true;
                
            }
            cardupdateK();
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
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Enabled = true;
            }
            hiba = 0;
            listain();
            label1.Text = "Fizika kérdések";
            button3.Visible = false;
            cardupdateK();
            counter = 10;
            label1.Text = "Válassz!";
        }
        private void listain()
        {
            KerdesLista = new Kerdesek();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            counter = 10;
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
            hiba = 0;
            listain();
            cardupdateK();
            this.Hide();
        }

    }
}
