namespace FizHelp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            animator = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(12, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(588, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(412, 385);
            button1.Name = "button1";
            button1.Size = new Size(174, 57);
            button1.TabIndex = 2;
            button1.Text = "Ellenőrzés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Algerian", 27.75F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(272, 41);
            label1.MinimumSize = new Size(500, 100);
            label1.Name = "label1";
            label1.Size = new Size(500, 100);
            label1.TabIndex = 3;
            label1.Text = "Fizika kérdések";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(412, 467);
            button2.Name = "button2";
            button2.Size = new Size(174, 65);
            button2.TabIndex = 4;
            button2.Text = "Másik Válasz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(401, 198);
            button3.Name = "button3";
            button3.Size = new Size(212, 108);
            button3.TabIndex = 7;
            button3.Text = "Újra";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(439, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
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
            button4.Location = new Point(70, 416);
            button4.Name = "button4";
            button4.Size = new Size(146, 86);
            button4.TabIndex = 10;
            button4.Text = "Kilépés";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = fiz.Properties.Resources.fizwallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 600);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fizika Beugró";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer animator;
        private Button button4;
    }
}
