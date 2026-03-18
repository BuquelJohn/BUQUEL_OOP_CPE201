namespace Lesson_2_Activity
{
    partial class FoodOrderingPrint
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDisplayListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDisplayListBox
            // 
            this.printDisplayListBox.FormattingEnabled = true;
            this.printDisplayListBox.Location = new System.Drawing.Point(32, 61);
            this.printDisplayListBox.Name = "printDisplayListBox";
            this.printDisplayListBox.Size = new System.Drawing.Size(531, 511);
            this.printDisplayListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANOK NI BUQUEL ORDERING APPLICATION";
            // 
            // Example_3_prntfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(590, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printDisplayListBox);
            this.Name = "Example_3_prntfrm";
            this.Text = "Example_3_prntfrm";
            this.Load += new System.EventHandler(this.Example_3_prntfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ListBox printDisplayListBox;
        private System.Windows.Forms.Label label1;
    }
}