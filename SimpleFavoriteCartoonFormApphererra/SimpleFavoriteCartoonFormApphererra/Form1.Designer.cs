namespace SimpleFavoriteCartoonFormApphererra
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
            label1 = new Label();
            charcombobox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            imgpicbox = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgpicbox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 71);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Characters";
            label1.Click += label1_Click;
            // 
            // charcombobox
            // 
            charcombobox.FormattingEnabled = true;
            charcombobox.Location = new Point(69, 127);
            charcombobox.Name = "charcombobox";
            charcombobox.Size = new Size(138, 28);
            charcombobox.TabIndex = 1;
            charcombobox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(82, 183);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(82, 237);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // imgpicbox
            // 
            imgpicbox.Location = new Point(467, 127);
            imgpicbox.Name = "imgpicbox";
            imgpicbox.Size = new Size(213, 176);
            imgpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgpicbox.TabIndex = 4;
            imgpicbox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 5;
            label2.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(238, 27);
            label3.Name = "label3";
            label3.Size = new Size(318, 28);
            label3.TabIndex = 6;
            label3.Text = "Simple favorite Character Picker";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(imgpicbox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(charcombobox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgpicbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox charcombobox;
        private Button button1;
        private Button button2;
        private PictureBox imgpicbox;
        private Label label2;
        private Label label3;
    }
}
