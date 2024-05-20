namespace FizHelp
{
    partial class ElesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElesForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            animator = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(12, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(976, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Algerian", 27.75F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(58, 44);
            label1.MinimumSize = new Size(900, 100);
            label1.Name = "label1";
            label1.Size = new Size(900, 100);
            label1.TabIndex = 3;
            label1.Text = "Fizika kérdések";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(354, 170);
            button3.Name = "button3";
            button3.Size = new Size(321, 143);
            button3.TabIndex = 7;
            button3.Text = "Újra";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(831, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(157, 105);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // animator
            // 
            animator.Interval = 1000;
            animator.Tick += animator_Tick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(146, 86);
            button4.TabIndex = 10;
            button4.Text = "Kilépés";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Silver;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(12, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 327);
            panel1.TabIndex = 11;
            // 
            // ElesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = fiz.Properties.Resources.fizwallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 600);
            Controls.Add(pictureBox3);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ElesForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fizika Beugró";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer animator;
        private Button button4;
        private Panel panel1;
    }
}
