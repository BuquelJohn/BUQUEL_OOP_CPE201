namespace   REAL_NA_TOH
{
    partial class Lesson7_Ex6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numTimesDisplayTxtbox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            displayListbox = new ListBox();
            countryCombobox = new ComboBox();
            SuspendLayout();
            // 
            // numTimesDisplayTxtbox
            // 
            numTimesDisplayTxtbox.Location = new Point(183, 48);
            numTimesDisplayTxtbox.Margin = new Padding(4, 3, 4, 3);
            numTimesDisplayTxtbox.Multiline = true;
            numTimesDisplayTxtbox.Name = "numTimesDisplayTxtbox";
            numTimesDisplayTxtbox.Size = new Size(186, 35);
            numTimesDisplayTxtbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter a number:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(377, 48);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(103, 37);
            button1.TabIndex = 2;
            button1.Text = "SHOW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 106);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(383, 20);
            label2.TabIndex = 3;
            label2.Text = "SELECT COUNTRY TO DISPLAY AT THE LISTBOX";
            // 
            // displayListbox
            // 
            displayListbox.FormattingEnabled = true;
            displayListbox.ItemHeight = 15;
            displayListbox.Location = new Point(36, 164);
            displayListbox.Margin = new Padding(4, 3, 4, 3);
            displayListbox.Name = "displayListbox";
            displayListbox.Size = new Size(443, 319);
            displayListbox.TabIndex = 4;
            // 
            // countryCombobox
            // 
            countryCombobox.FormattingEnabled = true;
            countryCombobox.Items.AddRange(new object[] { "Philippines", "Thailand", "China", "Hongkong", "Canada", "Hawaii", "South Korea" });
            countryCombobox.Location = new Point(36, 133);
            countryCombobox.Margin = new Padding(4, 3, 4, 3);
            countryCombobox.Name = "countryCombobox";
            countryCombobox.Size = new Size(443, 23);
            countryCombobox.TabIndex = 34;
            // 
            // while_loop2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(511, 519);
            Controls.Add(countryCombobox);
            Controls.Add(displayListbox);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numTimesDisplayTxtbox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "while_loop2";
            Text = "Example6";
            Load += while_loop2_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numTimesDisplayTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox displayListbox;
        private System.Windows.Forms.ComboBox countryCombobox;
    }
}