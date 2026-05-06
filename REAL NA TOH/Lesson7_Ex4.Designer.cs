using System.Drawing.Printing;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace REAL_NA_TOH
{
    partial class Lesson7_Ex4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Basic_RateTxtbox = new TextBox();
            Basic_CutoffTxtbox = new TextBox();
            Basic_IncomepercutoffTxtbox = new TextBox();
            Hono_totalpayTxtbox = new TextBox();
            Hono_CutoffTxtbox = new TextBox();
            Hono_RateTxtbox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Other_totalpayTxtbox = new TextBox();
            Other_CutoffTxtbox = new TextBox();
            Other_RateTxtbox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            Pagibig_ContribTxtbox = new TextBox();
            PhilHealth_ContribTxtbox = new TextBox();
            SSS_ContribTxtbox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            TaxtTxtbox = new TextBox();
            label17 = new Label();
            label18 = new Label();
            NetIncomeTxtbox = new TextBox();
            GrossIncomeTxtbox = new TextBox();
            TotalDeductionTxtbox = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "BASIC PAY";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 57);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "RATE/HOUR:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 93);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 2;
            label3.Text = "NO. OF HOURS/CUT OFF:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 129);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 3;
            label4.Text = "INCOME PER CUT OFF:";
            // 
            // Basic_RateTxtbox
            // 
            Basic_RateTxtbox.Location = new Point(232, 48);
            Basic_RateTxtbox.Margin = new Padding(3, 4, 3, 4);
            Basic_RateTxtbox.Name = "Basic_RateTxtbox";
            Basic_RateTxtbox.Size = new Size(262, 27);
            Basic_RateTxtbox.TabIndex = 4;
            // 
            // Basic_CutoffTxtbox
            // 
            Basic_CutoffTxtbox.Location = new Point(232, 87);
            Basic_CutoffTxtbox.Margin = new Padding(3, 4, 3, 4);
            Basic_CutoffTxtbox.Name = "Basic_CutoffTxtbox";
            Basic_CutoffTxtbox.Size = new Size(262, 27);
            Basic_CutoffTxtbox.TabIndex = 5;
            Basic_CutoffTxtbox.TextChanged += textBox2_TextChanged;
            // 
            // Basic_IncomepercutoffTxtbox
            // 
            Basic_IncomepercutoffTxtbox.Location = new Point(232, 128);
            Basic_IncomepercutoffTxtbox.Margin = new Padding(3, 4, 3, 4);
            Basic_IncomepercutoffTxtbox.Name = "Basic_IncomepercutoffTxtbox";
            Basic_IncomepercutoffTxtbox.Size = new Size(262, 27);
            Basic_IncomepercutoffTxtbox.TabIndex = 6;
            // 
            // Hono_totalpayTxtbox
            // 
            Hono_totalpayTxtbox.Location = new Point(232, 315);
            Hono_totalpayTxtbox.Margin = new Padding(3, 4, 3, 4);
            Hono_totalpayTxtbox.Name = "Hono_totalpayTxtbox";
            Hono_totalpayTxtbox.Size = new Size(262, 27);
            Hono_totalpayTxtbox.TabIndex = 12;
            // 
            // Hono_CutoffTxtbox
            // 
            Hono_CutoffTxtbox.Location = new Point(232, 273);
            Hono_CutoffTxtbox.Margin = new Padding(3, 4, 3, 4);
            Hono_CutoffTxtbox.Name = "Hono_CutoffTxtbox";
            Hono_CutoffTxtbox.Size = new Size(262, 27);
            Hono_CutoffTxtbox.TabIndex = 11;
            Hono_CutoffTxtbox.TextChanged += Hono_CutoffTxtbox_TextChanged;
            // 
            // Hono_RateTxtbox
            // 
            Hono_RateTxtbox.Location = new Point(232, 235);
            Hono_RateTxtbox.Margin = new Padding(3, 4, 3, 4);
            Hono_RateTxtbox.Name = "Hono_RateTxtbox";
            Hono_RateTxtbox.Size = new Size(262, 27);
            Hono_RateTxtbox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 316);
            label5.Name = "label5";
            label5.Size = new Size(184, 20);
            label5.TabIndex = 9;
            label5.Text = "TOTAL HONORARIUM PAY:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 280);
            label6.Name = "label6";
            label6.Size = new Size(174, 20);
            label6.TabIndex = 8;
            label6.Text = "NO. OF HOURS/CUT OFF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 244);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 7;
            label7.Text = "RATE/HOUR:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(14, 205);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 13;
            label8.Text = "HONORARIUM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(14, 368);
            label9.Name = "label9";
            label9.Size = new Size(120, 20);
            label9.TabIndex = 20;
            label9.Text = "OTHER INCOME";
            // 
            // Other_totalpayTxtbox
            // 
            Other_totalpayTxtbox.Location = new Point(232, 477);
            Other_totalpayTxtbox.Margin = new Padding(3, 4, 3, 4);
            Other_totalpayTxtbox.Name = "Other_totalpayTxtbox";
            Other_totalpayTxtbox.Size = new Size(262, 27);
            Other_totalpayTxtbox.TabIndex = 19;
            // 
            // Other_CutoffTxtbox
            // 
            Other_CutoffTxtbox.Location = new Point(232, 436);
            Other_CutoffTxtbox.Margin = new Padding(3, 4, 3, 4);
            Other_CutoffTxtbox.Name = "Other_CutoffTxtbox";
            Other_CutoffTxtbox.Size = new Size(262, 27);
            Other_CutoffTxtbox.TabIndex = 18;
            Other_CutoffTxtbox.TextChanged += textBox8_TextChanged;
            // 
            // Other_RateTxtbox
            // 
            Other_RateTxtbox.Location = new Point(232, 397);
            Other_RateTxtbox.Margin = new Padding(3, 4, 3, 4);
            Other_RateTxtbox.Name = "Other_RateTxtbox";
            Other_RateTxtbox.Size = new Size(262, 27);
            Other_RateTxtbox.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 479);
            label10.Name = "label10";
            label10.Size = new Size(191, 20);
            label10.TabIndex = 16;
            label10.Text = "TOTAL OTHER INCOME PAY:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 443);
            label11.Name = "label11";
            label11.Size = new Size(174, 20);
            label11.TabIndex = 15;
            label11.Text = "NO. OF HOURS/CUT OFF:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 407);
            label12.Name = "label12";
            label12.Size = new Size(93, 20);
            label12.TabIndex = 14;
            label12.Text = "RATE/HOUR:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(526, 17);
            label13.Name = "label13";
            label13.Size = new Size(169, 20);
            label13.TabIndex = 27;
            label13.Text = "REGULAR DEDUCTION";
            // 
            // Pagibig_ContribTxtbox
            // 
            Pagibig_ContribTxtbox.Location = new Point(766, 128);
            Pagibig_ContribTxtbox.Margin = new Padding(3, 4, 3, 4);
            Pagibig_ContribTxtbox.Name = "Pagibig_ContribTxtbox";
            Pagibig_ContribTxtbox.Size = new Size(262, 27);
            Pagibig_ContribTxtbox.TabIndex = 26;
            // 
            // PhilHealth_ContribTxtbox
            // 
            PhilHealth_ContribTxtbox.Location = new Point(766, 86);
            PhilHealth_ContribTxtbox.Margin = new Padding(3, 4, 3, 4);
            PhilHealth_ContribTxtbox.Name = "PhilHealth_ContribTxtbox";
            PhilHealth_ContribTxtbox.Size = new Size(262, 27);
            PhilHealth_ContribTxtbox.TabIndex = 25;
            // 
            // SSS_ContribTxtbox
            // 
            SSS_ContribTxtbox.Location = new Point(766, 48);
            SSS_ContribTxtbox.Margin = new Padding(3, 4, 3, 4);
            SSS_ContribTxtbox.Name = "SSS_ContribTxtbox";
            SSS_ContribTxtbox.Size = new Size(262, 27);
            SSS_ContribTxtbox.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(552, 128);
            label14.Name = "label14";
            label14.Size = new Size(175, 20);
            label14.TabIndex = 23;
            label14.Text = "PAGIBIG CONTRIBUTION:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(526, 93);
            label15.Name = "label15";
            label15.Size = new Size(205, 20);
            label15.TabIndex = 22;
            label15.Text = "PHILHEALTH CONTRIBUTION:";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(582, 56);
            label16.Name = "label16";
            label16.Size = new Size(145, 20);
            label16.TabIndex = 21;
            label16.Text = "SSS CONTRIBUTION:";
            // 
            // TaxtTxtbox
            // 
            TaxtTxtbox.Location = new Point(766, 166);
            TaxtTxtbox.Margin = new Padding(3, 4, 3, 4);
            TaxtTxtbox.Name = "TaxtTxtbox";
            TaxtTxtbox.Size = new Size(262, 27);
            TaxtTxtbox.TabIndex = 29;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(686, 173);
            label17.Name = "label17";
            label17.Size = new Size(38, 20);
            label17.TabIndex = 28;
            label17.Text = "TAX:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label18.Location = new Point(526, 235);
            label18.Name = "label18";
            label18.Size = new Size(129, 20);
            label18.TabIndex = 30;
            label18.Text = "INCOME SALARY";
            // 
            // NetIncomeTxtbox
            // 
            NetIncomeTxtbox.Location = new Point(744, 349);
            NetIncomeTxtbox.Margin = new Padding(3, 4, 3, 4);
            NetIncomeTxtbox.Name = "NetIncomeTxtbox";
            NetIncomeTxtbox.Size = new Size(262, 27);
            NetIncomeTxtbox.TabIndex = 36;
            // 
            // GrossIncomeTxtbox
            // 
            GrossIncomeTxtbox.Location = new Point(744, 308);
            GrossIncomeTxtbox.Margin = new Padding(3, 4, 3, 4);
            GrossIncomeTxtbox.Name = "GrossIncomeTxtbox";
            GrossIncomeTxtbox.Size = new Size(262, 27);
            GrossIncomeTxtbox.TabIndex = 35;
            // 
            // TotalDeductionTxtbox
            // 
            TotalDeductionTxtbox.Location = new Point(744, 255);
            TotalDeductionTxtbox.Margin = new Padding(3, 4, 3, 4);
            TotalDeductionTxtbox.Name = "TotalDeductionTxtbox";
            TotalDeductionTxtbox.Size = new Size(262, 27);
            TotalDeductionTxtbox.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(617, 357);
            label19.Name = "label19";
            label19.Size = new Size(99, 20);
            label19.TabIndex = 33;
            label19.Text = "NET INCOME:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(598, 316);
            label20.Name = "label20";
            label20.Size = new Size(118, 20);
            label20.TabIndex = 32;
            label20.Text = "GROSS INCOME:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(582, 279);
            label21.Name = "label21";
            label21.Size = new Size(140, 20);
            label21.TabIndex = 31;
            label21.Text = "TOTAL DEDUCTION:";
            // 
            // button1
            // 
            button1.Location = new Point(613, 411);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(174, 44);
            button1.TabIndex = 37;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(793, 411);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(106, 44);
            button2.TabIndex = 38;
            button2.Text = "NEW";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(906, 412);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(106, 41);
            button3.TabIndex = 39;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Lesson7_Ex4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1147, 543);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NetIncomeTxtbox);
            Controls.Add(GrossIncomeTxtbox);
            Controls.Add(TotalDeductionTxtbox);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label18);
            Controls.Add(TaxtTxtbox);
            Controls.Add(label17);
            Controls.Add(label13);
            Controls.Add(Pagibig_ContribTxtbox);
            Controls.Add(PhilHealth_ContribTxtbox);
            Controls.Add(SSS_ContribTxtbox);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label9);
            Controls.Add(Other_totalpayTxtbox);
            Controls.Add(Other_CutoffTxtbox);
            Controls.Add(Other_RateTxtbox);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(Hono_totalpayTxtbox);
            Controls.Add(Hono_CutoffTxtbox);
            Controls.Add(Hono_RateTxtbox);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(Basic_IncomepercutoffTxtbox);
            Controls.Add(Basic_CutoffTxtbox);
            Controls.Add(Basic_RateTxtbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lesson7_Ex4";
            Text = "LESSON7_EX4";
            Load += LESSON7_EX4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Basic_RateTxtbox;
        private TextBox Basic_CutoffTxtbox;
        private TextBox Basic_IncomepercutoffTxtbox;
        private TextBox Hono_totalpayTxtbox;
        private TextBox Hono_CutoffTxtbox;
        private TextBox Hono_RateTxtbox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox Other_totalpayTxtbox;
        private TextBox Other_CutoffTxtbox;
        private TextBox Other_RateTxtbox;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox Pagibig_ContribTxtbox;
        private TextBox PhilHealth_ContribTxtbox;
        private TextBox SSS_ContribTxtbox;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox TaxtTxtbox;
        private Label label17;
        private Label label18;
        private TextBox NetIncomeTxtbox;
        private TextBox GrossIncomeTxtbox;
        private TextBox TotalDeductionTxtbox;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}