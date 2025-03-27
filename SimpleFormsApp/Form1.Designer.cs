namespace SimpleFormsApp
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
            ClickBtn = new Button();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            label2 = new Label();
            txtSuffix = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // ClickBtn
            // 
            ClickBtn.Location = new Point(149, 266);
            ClickBtn.Name = "ClickBtn";
            ClickBtn.Size = new Size(255, 32);
            ClickBtn.TabIndex = 0;
            ClickBtn.Text = "Submit";
            ClickBtn.UseVisualStyleBackColor = true;
            ClickBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "First name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(149, 53);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(255, 23);
            txtFirstName.TabIndex = 2;
            txtFirstName.TextChanged += textBox1_TextChanged;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(149, 108);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(255, 23);
            txtMiddleName.TabIndex = 4;
            txtMiddleName.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 146);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Last name";
            // 
            // txtSuffix
            // 
            txtSuffix.Location = new Point(149, 219);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(255, 23);
            txtSuffix.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 201);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Suffix";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(149, 164);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(255, 23);
            txtLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 90);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 5;
            label4.Text = "Middle name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 22);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(664, 296);
            textBox5.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSuffix);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtMiddleName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(ClickBtn);
            Controls.Add(textBox5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClickBtn;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private Label label2;
        private TextBox txtSuffix;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox1;
    }
}
