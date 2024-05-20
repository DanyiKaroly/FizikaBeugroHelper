namespace FizHelp
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            animator = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(491, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(366, 366);
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
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(204, 29);
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
            button2.Location = new Point(366, 448);
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
            button3.Location = new Point(339, 196);
            button3.Name = "button3";
            button3.Size = new Size(212, 108);
            button3.TabIndex = 7;
            button3.Text = "Újra";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 70);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(583, 366);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(903, 541);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
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
        private Label label2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer animator;
    }
}
