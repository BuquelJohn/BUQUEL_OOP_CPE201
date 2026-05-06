using Lesson_2_Activity;
using LESSON1;
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
    public partial class MENUSTRIP : Form
    {
        public MENUSTRIP()
        {
            InitializeComponent();
        }

        private void activity1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1 activity1 = new Activity1();
            activity1.MdiParent = this;
            activity1.Show();
        }

        private void activity2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_2 activity2 = new Activity_2();
            activity2.MdiParent = this;
            activity2.Show();
        }

        private void activity3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_3 activity3 = new Activity_3();
            activity3.MdiParent = this;
            activity3.Show();
        }

        private void activity4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson2Act activity4 = new Lesson2Act();
            activity4.MdiParent = this;
            activity4.Show();
        }

        private void activity5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodOrderingForm activity5 = new FoodOrderingForm();
            activity5.MdiParent = this;
            activity5.Show();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayRollForm activity6 = new PayRollForm();
            activity6.MdiParent = this;
            activity6.Show();
        }

        private void activity4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            If_example activity1 = new If_example();
            activity1.MdiParent = this;
            activity1.Show();
        }

        private void activity6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson7_Ex5 example5 = new Lesson7_Ex5();
            example5.MdiParent = this;
            example5.Show();
        }

        private void activity5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            example_4 example4 = new example_4();
            example4.MdiParent = this;
            example4.Show();
        }

        private void activity4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Lesson7_Ex6 example5 = new Lesson7_Ex6();
            example5.MdiParent = this;
            example5.Show();
        }

        private void Example7looping_Load(object sender, EventArgs e)
        {

        }
    }
}
