namespace SimpleFormsAppWithCheckedListBox
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
            textBox1 = new TextBox();
            CheckListBox = new CheckedListBox();
            AddClick = new Button();
            ClearBtn = new Button();
            RemoveBtn = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(694, 236);
            textBox1.TabIndex = 0;
            // 
            // CheckListBox
            // 
            CheckListBox.FormattingEnabled = true;
            CheckListBox.Location = new Point(68, 56);
            CheckListBox.Name = "CheckListBox";
            CheckListBox.Size = new Size(195, 130);
            CheckListBox.TabIndex = 1;
            CheckListBox.SelectedIndexChanged += CheckListBox_SelectedIndexChanged;
            // 
            // AddClick
            // 
            AddClick.BackColor = SystemColors.ButtonHighlight;
            AddClick.ForeColor = SystemColors.ActiveCaptionText;
            AddClick.Location = new Point(88, 201);
            AddClick.Name = "AddClick";
            AddClick.Size = new Size(159, 34);
            AddClick.TabIndex = 2;
            AddClick.Text = "Add";
            AddClick.UseVisualStyleBackColor = false;
            AddClick.Click += AddClick_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = SystemColors.ButtonHighlight;
            ClearBtn.ForeColor = SystemColors.ActiveCaptionText;
            ClearBtn.Location = new Point(525, 123);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(98, 38);
            ClearBtn.TabIndex = 3;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = SystemColors.ButtonHighlight;
            RemoveBtn.ForeColor = SystemColors.ActiveCaptionText;
            RemoveBtn.Location = new Point(525, 65);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(98, 38);
            RemoveBtn.TabIndex = 4;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(316, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 139);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(RemoveBtn);
            Controls.Add(ClearBtn);
            Controls.Add(AddClick);
            Controls.Add(CheckListBox);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CheckedListBox CheckListBox;
        private Button AddClick;
        private Button ClearBtn;
        private Button RemoveBtn;
        private ListBox listBox1;
    }
}
