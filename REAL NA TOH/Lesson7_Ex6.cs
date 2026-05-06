using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace   REAL_NA_TOH
{
    public partial class Lesson7_Ex6 : Form
    {
        public Lesson7_Ex6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void while_loop2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int InitialValue = 0;
            int numTimesDisplay;
            numTimesDisplay = Convert.ToInt32(numTimesDisplayTxtbox.Text);
            do
            {
                displayListbox.Items.Add(countryCombobox.Text);
                InitialValue++;
            } while (InitialValue <= numTimesDisplay);
        }
    }
}
