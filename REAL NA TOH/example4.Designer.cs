namespace REAL_NA_TOH
{
    partial class example4
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
            BasicRateTxtbox = new TextBox();
            BasicCutoffTxtbox = new TextBox();
            label3 = new Label();
            BasicIncomeTxtbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TotalHonorariumTxtbox = new TextBox();
            label6 = new Label();
            HonorariumCutoffTxtbox = new TextBox();
            label7 = new Label();
            HonorariumRateTxtbox = new TextBox();
            label8 = new Label();
            TotalOtherTxtbox = new TextBox();
            label9 = new Label();
            OtherCutoffTxtbox = new TextBox();
            label10 = new Label();
            OtherRateTxtbox = new TextBox();
            label11 = new Label();
            label12 = new Label();
            PagibigContributionTxtbox = new TextBox();
            label13 = new Label();
            PhilhealthContributionTxtbox = new TextBox();
            label14 = new Label();
            SSScontributionTxtbox = new TextBox();
            label15 = new Label();
            label16 = new Label();
            TaxTxtbox = new TextBox();
            label17 = new Label();
            NetIncomeTxtbox = new TextBox();
            label18 = new Label();
            GrossIncomeTxtbox = new TextBox();
            label19 = new Label();
            TotalDeductionsTxtbox = new TextBox();
            label20 = new Label();
            label21 = new Label();
            CalculateBtn = new Button();
            NewBtn = new Button();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label1.Location = new Point(10, 34);
            label1.Name = "label1";
            label1.Size = new Size(75, 16);
            label1.TabIndex = 0;
            label1.Text = "BASIC PAY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.Location = new Point(32, 60);
            label2.Name = "label2";
            label2.Size = new Size(77, 16);
            label2.TabIndex = 1;
            label2.Text = "Rate / Hour:";
            // 
            // BasicRateTxtbox
            // 
            BasicRateTxtbox.Font = new Font("Arial", 9.75F);
            BasicRateTxtbox.Location = new Point(126, 55);
            BasicRateTxtbox.Margin = new Padding(3, 2, 3, 2);
            BasicRateTxtbox.Name = "BasicRateTxtbox";
            BasicRateTxtbox.Size = new Size(324, 22);
            BasicRateTxtbox.TabIndex = 2;
            BasicRateTxtbox.TextChanged += textBox1_TextChanged;
            // 
            // BasicCutoffTxtbox
            // 
            BasicCutoffTxtbox.Font = new Font("Arial", 9.75F);
            BasicCutoffTxtbox.Location = new Point(175, 82);
            BasicCutoffTxtbox.Margin = new Padding(3, 2, 3, 2);
            BasicCutoffTxtbox.Name = "BasicCutoffTxtbox";
            BasicCutoffTxtbox.Size = new Size(275, 22);
            BasicCutoffTxtbox.TabIndex = 4;
            BasicCutoffTxtbox.Leave += BasicCutoffTxtbox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.Location = new Point(32, 87);
            label3.Name = "label3";
            label3.Size = new Size(135, 16);
            label3.TabIndex = 3;
            label3.Text = "No. of Hours / Cut Off:";
            // 
            // BasicIncomeTxtbox
            // 
            BasicIncomeTxtbox.Font = new Font("Arial", 9.75F);
            BasicIncomeTxtbox.Location = new Point(175, 109);
            BasicIncomeTxtbox.Margin = new Padding(3, 2, 3, 2);
            BasicIncomeTxtbox.Name = "BasicIncomeTxtbox";
            BasicIncomeTxtbox.Size = new Size(275, 22);
            BasicIncomeTxtbox.TabIndex = 6;
            BasicIncomeTxtbox.Leave += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.Location = new Point(32, 115);
            label4.Name = "label4";
            label4.Size = new Size(121, 16);
            label4.TabIndex = 5;
            label4.Text = "Income Per Cut Off:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(10, 148);
            label5.Name = "label5";
            label5.Size = new Size(96, 16);
            label5.TabIndex = 7;
            label5.Text = "HONORARIUM";
            // 
            // TotalHonorariumTxtbox
            // 
            TotalHonorariumTxtbox.Font = new Font("Arial", 9.75F);
            TotalHonorariumTxtbox.Location = new Point(175, 223);
            TotalHonorariumTxtbox.Margin = new Padding(3, 2, 3, 2);
            TotalHonorariumTxtbox.Name = "TotalHonorariumTxtbox";
            TotalHonorariumTxtbox.Size = new Size(275, 22);
            TotalHonorariumTxtbox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F);
            label6.Location = new Point(31, 229);
            label6.Name = "label6";
            label6.Size = new Size(135, 16);
            label6.TabIndex = 12;
            label6.Text = "Total Honorarium Pay:";
            // 
            // HonorariumCutoffTxtbox
            // 
            HonorariumCutoffTxtbox.Font = new Font("Arial", 9.75F);
            HonorariumCutoffTxtbox.Location = new Point(175, 196);
            HonorariumCutoffTxtbox.Margin = new Padding(3, 2, 3, 2);
            HonorariumCutoffTxtbox.Name = "HonorariumCutoffTxtbox";
            HonorariumCutoffTxtbox.Size = new Size(275, 22);
            HonorariumCutoffTxtbox.TabIndex = 11;
            HonorariumCutoffTxtbox.Leave += HonorariumCutoffTxtbox_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F);
            label7.Location = new Point(32, 201);
            label7.Name = "label7";
            label7.Size = new Size(135, 16);
            label7.TabIndex = 10;
            label7.Text = "No. of Hours / Cut Off:";
            // 
            // HonorariumRateTxtbox
            // 
            HonorariumRateTxtbox.Font = new Font("Arial", 9.75F);
            HonorariumRateTxtbox.Location = new Point(126, 169);
            HonorariumRateTxtbox.Margin = new Padding(3, 2, 3, 2);
            HonorariumRateTxtbox.Name = "HonorariumRateTxtbox";
            HonorariumRateTxtbox.Size = new Size(324, 22);
            HonorariumRateTxtbox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F);
            label8.Location = new Point(32, 174);
            label8.Name = "label8";
            label8.Size = new Size(77, 16);
            label8.TabIndex = 8;
            label8.Text = "Rate / Hour:";
            // 
            // TotalOtherTxtbox
            // 
            TotalOtherTxtbox.Font = new Font("Arial", 9.75F);
            TotalOtherTxtbox.Location = new Point(175, 332);
            TotalOtherTxtbox.Margin = new Padding(3, 2, 3, 2);
            TotalOtherTxtbox.Name = "TotalOtherTxtbox";
            TotalOtherTxtbox.Size = new Size(275, 22);
            TotalOtherTxtbox.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F);
            label9.Location = new Point(22, 335);
            label9.Name = "label9";
            label9.Size = new Size(147, 16);
            label9.TabIndex = 19;
            label9.Text = "Total Other Income Pay:";
            // 
            // OtherCutoffTxtbox
            // 
            OtherCutoffTxtbox.Font = new Font("Arial", 9.75F);
            OtherCutoffTxtbox.Location = new Point(175, 305);
            OtherCutoffTxtbox.Margin = new Padding(3, 2, 3, 2);
            OtherCutoffTxtbox.Name = "OtherCutoffTxtbox";
            OtherCutoffTxtbox.Size = new Size(275, 22);
            OtherCutoffTxtbox.TabIndex = 18;
            OtherCutoffTxtbox.Leave += OtherCutoffTxtbox_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F);
            label10.Location = new Point(32, 311);
            label10.Name = "label10";
            label10.Size = new Size(135, 16);
            label10.TabIndex = 17;
            label10.Text = "No. of Hours / Cut Off:";
            // 
            // OtherRateTxtbox
            // 
            OtherRateTxtbox.Font = new Font("Arial", 9.75F);
            OtherRateTxtbox.Location = new Point(126, 278);
            OtherRateTxtbox.Margin = new Padding(3, 2, 3, 2);
            OtherRateTxtbox.Name = "OtherRateTxtbox";
            OtherRateTxtbox.Size = new Size(324, 22);
            OtherRateTxtbox.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F);
            label11.Location = new Point(32, 284);
            label11.Name = "label11";
            label11.Size = new Size(77, 16);
            label11.TabIndex = 15;
            label11.Text = "Rate / Hour:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label12.Location = new Point(10, 258);
            label12.Name = "label12";
            label12.Size = new Size(106, 16);
            label12.TabIndex = 14;
            label12.Text = "OTHER INCOME";
            // 
            // PagibigContributionTxtbox
            // 
            PagibigContributionTxtbox.Font = new Font("Arial", 9.75F);
            PagibigContributionTxtbox.Location = new Point(642, 111);
            PagibigContributionTxtbox.Margin = new Padding(3, 2, 3, 2);
            PagibigContributionTxtbox.Name = "PagibigContributionTxtbox";
            PagibigContributionTxtbox.Size = new Size(294, 22);
            PagibigContributionTxtbox.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F);
            label13.Location = new Point(502, 115);
            label13.Name = "label13";
            label13.Size = new Size(127, 16);
            label13.TabIndex = 26;
            label13.Text = "PagIbig Contribution:";
            // 
            // PhilhealthContributionTxtbox
            // 
            PhilhealthContributionTxtbox.Font = new Font("Arial", 9.75F);
            PhilhealthContributionTxtbox.Location = new Point(642, 84);
            PhilhealthContributionTxtbox.Margin = new Padding(3, 2, 3, 2);
            PhilhealthContributionTxtbox.Name = "PhilhealthContributionTxtbox";
            PhilhealthContributionTxtbox.Size = new Size(294, 22);
            PhilhealthContributionTxtbox.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F);
            label14.Location = new Point(501, 87);
            label14.Name = "label14";
            label14.Size = new Size(143, 16);
            label14.TabIndex = 24;
            label14.Text = "PhilHealth Contribution:";
            // 
            // SSScontributionTxtbox
            // 
            SSScontributionTxtbox.Font = new Font("Arial", 9.75F);
            SSScontributionTxtbox.Location = new Point(619, 57);
            SSScontributionTxtbox.Margin = new Padding(3, 2, 3, 2);
            SSScontributionTxtbox.Name = "SSScontributionTxtbox";
            SSScontributionTxtbox.Size = new Size(317, 22);
            SSScontributionTxtbox.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F);
            label15.Location = new Point(502, 60);
            label15.Name = "label15";
            label15.Size = new Size(111, 16);
            label15.TabIndex = 22;
            label15.Text = "SSS Contribution:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label16.Location = new Point(480, 34);
            label16.Name = "label16";
            label16.Size = new Size(157, 16);
            label16.TabIndex = 21;
            label16.Text = "REGULAR DEDUCTIONS";
            // 
            // TaxTxtbox
            // 
            TaxTxtbox.Font = new Font("Arial", 9.75F);
            TaxTxtbox.Location = new Point(642, 138);
            TaxTxtbox.Margin = new Padding(3, 2, 3, 2);
            TaxTxtbox.Name = "TaxTxtbox";
            TaxTxtbox.Size = new Size(294, 22);
            TaxTxtbox.TabIndex = 29;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F);
            label17.Location = new Point(604, 141);
            label17.Name = "label17";
            label17.Size = new Size(31, 16);
            label17.TabIndex = 28;
            label17.Text = "Tax:";
            // 
            // NetIncomeTxtbox
            // 
            NetIncomeTxtbox.Font = new Font("Arial", 9.75F);
            NetIncomeTxtbox.Location = new Point(616, 252);
            NetIncomeTxtbox.Margin = new Padding(3, 2, 3, 2);
            NetIncomeTxtbox.Name = "NetIncomeTxtbox";
            NetIncomeTxtbox.Size = new Size(320, 22);
            NetIncomeTxtbox.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F);
            label18.Location = new Point(491, 255);
            label18.Name = "label18";
            label18.Size = new Size(91, 16);
            label18.TabIndex = 35;
            label18.Text = "NET INCOME:";
            // 
            // GrossIncomeTxtbox
            // 
            GrossIncomeTxtbox.Font = new Font("Arial", 9.75F);
            GrossIncomeTxtbox.Location = new Point(616, 225);
            GrossIncomeTxtbox.Margin = new Padding(3, 2, 3, 2);
            GrossIncomeTxtbox.Name = "GrossIncomeTxtbox";
            GrossIncomeTxtbox.Size = new Size(320, 22);
            GrossIncomeTxtbox.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9.75F);
            label19.Location = new Point(491, 229);
            label19.Name = "label19";
            label19.Size = new Size(113, 16);
            label19.TabIndex = 33;
            label19.Text = "GROSS INCOME:";
            // 
            // TotalDeductionsTxtbox
            // 
            TotalDeductionsTxtbox.Font = new Font("Arial", 9.75F);
            TotalDeductionsTxtbox.Location = new Point(634, 199);
            TotalDeductionsTxtbox.Margin = new Padding(3, 2, 3, 2);
            TotalDeductionsTxtbox.Name = "TotalDeductionsTxtbox";
            TotalDeductionsTxtbox.Size = new Size(302, 22);
            TotalDeductionsTxtbox.TabIndex = 32;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 9.75F);
            label20.Location = new Point(491, 205);
            label20.Name = "label20";
            label20.Size = new Size(137, 16);
            label20.TabIndex = 31;
            label20.Text = "TOTAL DEDUCTIONS:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label21.Location = new Point(480, 178);
            label21.Name = "label21";
            label21.Size = new Size(128, 16);
            label21.TabIndex = 30;
            label21.Text = "INCOME SUMMARY";
            // 
            // CalculateBtn
            // 
            CalculateBtn.Font = new Font("Arial", 9.75F);
            CalculateBtn.Location = new Point(480, 290);
            CalculateBtn.Margin = new Padding(3, 2, 3, 2);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(148, 37);
            CalculateBtn.TabIndex = 37;
            CalculateBtn.Text = "CALCULATE";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // NewBtn
            // 
            NewBtn.Font = new Font("Arial", 9.75F);
            NewBtn.Location = new Point(634, 290);
            NewBtn.Margin = new Padding(3, 2, 3, 2);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(148, 37);
            NewBtn.TabIndex = 38;
            NewBtn.Text = "NEW";
            NewBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Font = new Font("Arial", 9.75F);
            ExitBtn.Location = new Point(787, 290);
            ExitBtn.Margin = new Padding(3, 2, 3, 2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(148, 37);
            ExitBtn.TabIndex = 39;
            ExitBtn.Text = "EXIT";
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // example4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(981, 398);
            Controls.Add(ExitBtn);
            Controls.Add(NewBtn);
            Controls.Add(CalculateBtn);
            Controls.Add(NetIncomeTxtbox);
            Controls.Add(label18);
            Controls.Add(GrossIncomeTxtbox);
            Controls.Add(label19);
            Controls.Add(TotalDeductionsTxtbox);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(TaxTxtbox);
            Controls.Add(label17);
            Controls.Add(PagibigContributionTxtbox);
            Controls.Add(label13);
            Controls.Add(PhilhealthContributionTxtbox);
            Controls.Add(label14);
            Controls.Add(SSScontributionTxtbox);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(TotalOtherTxtbox);
            Controls.Add(label9);
            Controls.Add(OtherCutoffTxtbox);
            Controls.Add(label10);
            Controls.Add(OtherRateTxtbox);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(TotalHonorariumTxtbox);
            Controls.Add(label6);
            Controls.Add(HonorariumCutoffTxtbox);
            Controls.Add(label7);
            Controls.Add(HonorariumRateTxtbox);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(BasicIncomeTxtbox);
            Controls.Add(label4);
            Controls.Add(BasicCutoffTxtbox);
            Controls.Add(label3);
            Controls.Add(BasicRateTxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "example4";
            Text = "Example4_Lesson7";
            Load += Example4_Lesson7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox BasicRateTxtbox;
        private TextBox BasicCutoffTxtbox;
        private Label label3;
        private TextBox BasicIncomeTxtbox;
        private Label label4;
        private Label label5;
        private TextBox TotalHonorariumTxtbox;
        private Label label6;
        private TextBox HonorariumCutoffTxtbox;
        private Label label7;
        private TextBox HonorariumRateTxtbox;
        private Label label8;
        private TextBox TotalOtherTxtbox;
        private Label label9;
        private TextBox OtherCutoffTxtbox;
        private Label label10;
        private TextBox OtherRateTxtbox;
        private Label label11;
        private Label label12;
        private TextBox PagibigContributionTxtbox;
        private Label label13;
        private TextBox PhilhealthContributionTxtbox;
        private Label label14;
        private TextBox SSScontributionTxtbox;
        private Label label15;
        private Label label16;
        private TextBox TaxTxtbox;
        private Label label17;
        private TextBox NetIncomeTxtbox;
        private Label label18;
        private TextBox GrossIncomeTxtbox;
        private Label label19;
        private TextBox TotalDeductionsTxtbox;
        private Label label20;
        private Label label21;
        private Button CalculateBtn;
        private Button NewBtn;
        private Button ExitBtn;
    }
}