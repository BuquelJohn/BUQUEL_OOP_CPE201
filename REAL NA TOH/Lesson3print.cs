using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REAL_NA_TOH
{
    public partial class Lesson3print : Form
    {
        public Lesson3print(ListBox.ObjectCollection items)
        {
            InitializeComponent();
            printDisplayListBox.Items.Clear();
            printDisplayListBox.Items.AddRange(items);
        }

        private void Example_3_prntfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
