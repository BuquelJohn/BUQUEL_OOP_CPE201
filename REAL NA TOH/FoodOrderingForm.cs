using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson_2_Activity
{
    public partial class FoodOrderingForm : Form
    {
        //Declare variables to store the total amount and quantity
        private double total_amount = 0;
        private int total_qty = 0;

        public FoodOrderingForm()
        {
            InitializeComponent();
        }

        private void Example_3_Load(object sender, EventArgs e)
        {
            //Disable the textboxes to prevent user input
            PriceTxtbox.Enabled = false;
            DiscountedTxtbox.Enabled = false;
            ChangeTxtbox.Enabled = false;
            TotalBillsTxtbox.Enabled = false;
            DiscountTxtbox.Enabled = false;
            TotalQtyTxtbox.Enabled = false;

            //Inserting image to picturebox
            //Burger1IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Southern fried.png");
            //Burger2IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 182322.png");
            //Burger3IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 165312.png");
            //Burger4IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Chicken chowmein.png");
            //Burger5IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Fried breast.png");
            //Burger6IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Chicken tinola.png");
            //Burger7IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 172855.png");
            //Burger8IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 172657.png");
            //Burger9IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 172601.png");
            //Burger10IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 172438.png");
            //Burger11IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 172354.png");
            //Burger12IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 172149.png");
            //Burger13IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 171916.png");
            //Burger14IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 171623.png");
            //Burger15IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 171004.png");
            //Burger16IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 170903.png");
            //Burger17IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 165548.png");
            //Burger18IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 165503.png");
            //Burger19IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 165356.png");
            //Burger20IMG.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Fresh chicken.png");

            //disable the checkboxes to prevent user input
            A_BucketfriesBox.Enabled = false;
            A_ChickenBox.Enabled = false;
            A_DeluxeburgerBox.Enabled = false;
            A_Icedteabox.Enabled = false;
            A_SidedishBox.Enabled = false;
            B_chickenBox.Enabled = false;
            B_HalohaloBox.Enabled = false;
            B_LargefriesBox.Enabled = false;
            B_SDeluxeburgerbox.Enabled = false;
            B_SpaghettiBox.Enabled = false;




        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code to uncheck all given checkboxes
            FoodBundleA_RB.Checked = false;
            FoodBundleB_RB.Checked = false;

            //code for inserting default image inside the picturebox
            DisplayPicturebox.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Fresh chicken.png");
            A_BucketfriesBox.Checked = false;
            A_ChickenBox.Checked = false;
            A_DeluxeburgerBox.Checked = false;
            A_Icedteabox.Checked = false;
            A_SidedishBox.Checked = false;
            B_chickenBox.Checked = false;
            B_HalohaloBox.Checked = false;
            B_LargefriesBox.Checked = false;
            B_SDeluxeburgerbox.Checked = false;
            B_SpaghettiBox.Checked = false;

            //code for clearing the textboxes
            QtyTxtbox.Clear();
            PriceTxtbox.Clear();
            Chicken1CB.Checked = false;
            Chicken2CB.Checked = false;
            Chicken3CB.Checked = false;
            Chicken4CB.Checked = false;
            Chicken5CB.Checked = false;
            Chicken6CB.Checked = false;
            Chicken7CB.Checked = false;
            Chicken8CB.Checked = false;
            Chicken9CB.Checked = false;
            Chicken10CB.Checked = false;
            Chicken11CB.Checked = false;
            Chicken12CB.Checked = false;
            Chicken13CB.Checked = false;
            Chicken14CB.Checked = false;
            Chicken15CB.Checked = false;
            Chicken16CB.Checked = false;
            Chicken17CB.Checked = false;
            Chicken18CB.Checked = false;
            Chicken19CB.Checked = false;
            Chicken20CB.Checked = false;

            //remove all data inside the listbox
            DisplayListbox.Items.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code to remove selected data inside the listbox
            DisplayListbox.Items.RemoveAt(DisplayListbox.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FoodOrderingPrint print = new FoodOrderingPrint(DisplayListbox.Items);
            print.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double cash_given, change, total_amountPaid;
                cash_given = Convert.ToDouble(CashGivenTxtbox.Text);
                total_amountPaid = Convert.ToDouble(TotalBillsTxtbox.Text);
                change = cash_given - total_amountPaid;
                ChangeTxtbox.Text = change.ToString("n");
                DisplayListbox.Items.Add("total Bills: " + " " + TotalBillsTxtbox.Text);
                DisplayListbox.Items.Add("Cash Given: " + " " + CashGivenTxtbox.Text);
                DisplayListbox.Items.Add("Change: " + " " + ChangeTxtbox.Text);
                DisplayListbox.Items.Add("Total No. of Items:" + " " + TotalQtyTxtbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid data in cash given textbox!");
                CashGivenTxtbox.Clear();
            }
        }

        private void Burger1IMG_Click(object sender, EventArgs e)
        {

        }

        private void FoodBundleA_RB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            // changing the form background
            this.BackColor = Color.Brown;

            // code for food bundle B not be selected
            FoodBundleB_RB.Checked = false;

            // inserting image to picturebox
            //DisplayPicturebox.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Fresh chicken.png");

            // codes to check the checkboxes when food bundle A is selected
            A_BucketfriesBox.Checked = true;
            A_ChickenBox.Checked = true;
            A_DeluxeburgerBox.Checked = true;
            A_Icedteabox.Checked = true;
            A_SidedishBox.Checked = true;

            //codes to uncheck the checkboxes when food bundle A is selected
            B_chickenBox.Checked = false;
            B_HalohaloBox.Checked = false;
            B_LargefriesBox.Checked = false;
            B_SDeluxeburgerbox.Checked = false;
            B_SpaghettiBox.Checked = false;

            //codes for displaying data inside the textboxes
            PriceTxtbox.Text = "1,000.00";
            DiscountTxtbox.Text = "200.00";
            price = Convert.ToDouble(PriceTxtbox.Text);

            //codes for inserting data inside the listbox
            DisplayListbox.Items.Add(FoodBundleA_RB.Text + " " + PriceTxtbox.Text);
            DisplayListbox.Items.Add("Discount amount: " + " " + DiscountTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();

        }

        private void DisplayPicturebox_Click(object sender, EventArgs e)
        {

        }

        private void FoodBundleB_RB_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Firebrick;
            FoodBundleA_RB.Checked = false;
            DisplayPicturebox.Image = System.Drawing.Image.FromFile("C:\\Users\\C203-04.C203-04\\Downloads\\manok ni buquel\\Screenshot 2026-02-04 170903.png");
            A_BucketfriesBox.Checked = false;
            A_ChickenBox.Checked = false;
            A_DeluxeburgerBox.Checked = false;
            A_Icedteabox.Checked = false;
            A_SidedishBox.Checked = false;
            B_chickenBox.Checked = true;
            B_HalohaloBox.Checked = true;
            B_LargefriesBox.Checked = true;
            B_SDeluxeburgerbox.Checked = true;
            B_SpaghettiBox.Checked = true;
            PriceTxtbox.Text = "1,299.00";
            DiscountTxtbox.Text = "194.85";
            DisplayListbox.Items.Add(FoodBundleB_RB.Text);
        }

        private void QtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double price, discounted_amount, discount_amount;
                int qty;
                price = Convert.ToDouble(PriceTxtbox.Text);
                qty = Convert.ToInt32(QtyTxtbox.Text);
                discount_amount = Convert.ToDouble(DiscountTxtbox.Text);
                discounted_amount = (price * qty) - discount_amount;
                total_qty += qty;
                TotalQtyTxtbox.Text = total_qty.ToString();
                total_amount += discounted_amount;
                TotalBillsTxtbox.Text = total_amount.ToString("n");
                DiscountedTxtbox.Text = discounted_amount.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter number of quantity ordered!");
                QtyTxtbox.Clear();
            }
        }

        private void Burger1CB_CheckedChanged(object sender, EventArgs e)
        {
            //code to declare a variable with specific data type
            double price;

            //code for putting text property value of the textbox
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "500.99";

            //code for converting string to numeric data type
            price = Convert.ToDouble(PriceTxtbox.Text);

            //code for inserting texxt property value of the checkbox to the listbox
            DisplayListbox.Items.Add(Chicken1CB.Text + " " + PriceTxtbox.Text);

            //code for putting text property value of the textbox
            QtyTxtbox.Text = "0";

            //code for putting the focus on the textbox
            QtyTxtbox.Focus();
        }

        private void Burger2CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "550.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken2CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger3CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "600.99";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken3CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger4CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "700.50";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken4CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger5CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "500.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken5CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger6CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "750.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken6CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger7CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "700.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken7CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger8CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "850.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken8CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger9CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "450.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken9CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger10CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "650.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken10CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger11CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken11CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger12CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken12CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger13CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken13CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger14CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken14CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger15CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken15CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger16CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken16CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger17CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken17CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger18CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken18CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger19CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken19CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void Burger20CB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            DiscountTxtbox.Text = "00.00";
            PriceTxtbox.Text = "575.00";
            price = Convert.ToDouble(PriceTxtbox.Text);
            DisplayListbox.Items.Add(Chicken20CB.Text + " " + PriceTxtbox.Text);
            QtyTxtbox.Text = "0";
            QtyTxtbox.Focus();
        }

        private void A_Icedteabox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DisplayListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CashGivenTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
