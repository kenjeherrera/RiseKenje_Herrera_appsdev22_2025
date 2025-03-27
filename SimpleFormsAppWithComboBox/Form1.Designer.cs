namespace SimpleFormsAppWithComboBox
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
            cmbCuisine = new ComboBox();
            SelectBtn = new Button();
            clbFoodItems = new CheckedListBox();
            lstSelectedFoods = new ListBox();
            AddBtn = new Button();
            RemoveBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // cmbCuisine
            // 
            cmbCuisine.FormattingEnabled = true;
            cmbCuisine.Location = new Point(33, 39);
            cmbCuisine.Name = "cmbCuisine";
            cmbCuisine.Size = new Size(121, 23);
            cmbCuisine.TabIndex = 0;
            cmbCuisine.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // SelectBtn
            // 
            SelectBtn.Location = new Point(33, 68);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(121, 23);
            SelectBtn.TabIndex = 1;
            SelectBtn.Text = "button1";
            SelectBtn.UseVisualStyleBackColor = true;
            // 
            // clbFoodItems
            // 
            clbFoodItems.FormattingEnabled = true;
            clbFoodItems.Location = new Point(228, 39);
            clbFoodItems.Name = "clbFoodItems";
            clbFoodItems.Size = new Size(120, 94);
            clbFoodItems.TabIndex = 2;
            // 
            // lstSelectedFoods
            // 
            lstSelectedFoods.FormattingEnabled = true;
            lstSelectedFoods.ItemHeight = 15;
            lstSelectedFoods.Location = new Point(417, 39);
            lstSelectedFoods.Name = "lstSelectedFoods";
            lstSelectedFoods.Size = new Size(120, 94);
            lstSelectedFoods.TabIndex = 3;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(228, 139);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(121, 23);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "button2";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(573, 39);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(121, 23);
            RemoveBtn.TabIndex = 5;
            RemoveBtn.Text = "button3";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(573, 94);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(121, 23);
            ClearBtn.TabIndex = 6;
            ClearBtn.Text = "button4";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(AddBtn);
            Controls.Add(lstSelectedFoods);
            Controls.Add(clbFoodItems);
            Controls.Add(SelectBtn);
            Controls.Add(cmbCuisine);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCuisine;
        private Button SelectBtn;
        private CheckedListBox clbFoodItems;
        private ListBox lstSelectedFoods;
        private Button AddBtn;
        private Button RemoveBtn;
        private Button ClearBtn;
    }
}
