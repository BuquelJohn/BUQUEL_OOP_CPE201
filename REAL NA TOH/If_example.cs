namespace REAL_NA_TOH
{
    public partial class If_example : Form
    {
        // decleration 
        private string picpath;
        private double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.0;
        private double net_income = 0.00,
            grossincom = 0.00,
            sss_contrib = 0.00,
            pagibig_contib = 0.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;

        private double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salaray_loan = 0.00,
            salaray_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;

        public If_example()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void basic_Nohrs_co_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = double.Parse(basic_Nohrs_co.Text);
            basic_rate = Convert.ToDouble(basic_rhr.Text);
            basic_netincome = basic_numhrs * basic_rate;
            basic_incco.Text = basic_netincome.ToString("n");
        }

        private void hi_Nohrs_co_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = double.Parse(hi_Nohrs_co.Text);
            hono_rate = Convert.ToDouble(hi_rhr.Text);
            hono_netincome = hono_numhrs * hono_rate;
            hi_inc_co.Text = hono_netincome.ToString("n");
        }

        private void oi_Nohrs_co_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = double.Parse(oi_Nohrs_co.Text);
            other_rate = Convert.ToDouble(oi_rhr.Text);
            other_netincome = other_numhrs * other_rate;
            oi_Nohrs_co.Text = other_netincome.ToString("n");
            basic_netincome = Convert.ToDouble(basic_incco.Text);
            hono_netincome = Convert.ToDouble(hi_inc_co.Text);
            other_netincome = Convert.ToDouble(oi_inc_co.Text);
            grossincom = basic_netincome + hono_netincome + other_netincome;
            si_ginc.Text = grossincom.ToString("n");


        }

        private void si_ginc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
