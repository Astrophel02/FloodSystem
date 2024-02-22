using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloodDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 变化检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change form = new change();
            form.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sVMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_classification form_Classification = new Form_classification();
            form_Classification.Show();
        }
    }
}
