using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REAL_NA_TOH
{
    public partial class Act2 : Form
    {
        private double total_amount = 0;
        private int qty_total = 0;
        private double discount_totalgiven = 0;
        private double discounted_total = 0;

        public Act2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discounttxtbox.Text);
            discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            cash_rendered = Convert.ToDouble(cashre_renderedtxtbox.Text);

            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;

            quantity_totaltxtbox.Text = qty_total.ToString();
            discount_totaltxtbox.Text = discount_totalgiven.ToString("n");
            discounted_totaltxtbox.Text = discounted_total.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashre_renderedtxtbox.Text = cash_rendered.ToString("n");
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Act2_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;

            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            quantity_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;

            pictureBox16.Image = Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Fresh chicken.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Chicken chowmein.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Fried breast.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Southern fried.png");
            pictureBox20.Image = Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Chicken tinola.png");

            name1lbl.Text = "Fried chicken";
            name2lbl.Text = "Sweet spicy";
            name3lbl.Text = "Chicken teriyaki";
            name4lbl.Text = "Korean fried";
            name5lbl.Text = "Whole roasted";
            name6lbl.Text = "Honey sesame";
            name7lbl.Text = "Jamaican jerk";
            name8lbl.Text = "Fried rice";
            name9lbl.Text = "Chicken salad";
            name10lbl.Text = "Chicken skewer";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken tinola";
            pricetextbox.Text = "150";
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashre_renderedtxtbox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Fried Chicken";
            pricetextbox.Text = "150";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Sweet spicy";
            pricetextbox.Text = "150";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken teriyaki";
            pricetextbox.Text = "150";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Korean fried";
            pricetextbox.Text = "150";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Whole roasted";
            pricetextbox.Text = "800";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Honey sesame";
            pricetextbox.Text = "150";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Jamaican jerk";
            pricetextbox.Text = "150";
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Fried rice";
            pricetextbox.Text = "150";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken salad";
            pricetextbox.Text = "150";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken skewer";
            pricetextbox.Text = "150";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken nachos";
            pricetextbox.Text = "150";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken wraps";
            pricetextbox.Text = "150";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken pasta";
            pricetextbox.Text = "150";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken soup";
            pricetextbox.Text = "150";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken adobo";
            pricetextbox.Text = "150";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Southern fried";
            pricetextbox.Text = "150";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Fried breast";
            pricetextbox.Text = "150";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken chowmein";
            pricetextbox.Text = "150";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Fresh chicken";
            pricetextbox.Text = "900";
        }

        private void cash_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtytxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_totaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
