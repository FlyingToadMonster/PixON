using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixON
{
    public partial class PixON : Form
    {
        private QuickBar qb;

        public PixON()
        {
            InitializeComponent();
            qb = new QuickBar();
            qb.mainForm = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnQBar_Click(object sender, EventArgs e)
        {
            qb.Show();
            Hide();
        }
    }
}
