using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PixON
{
    public partial class PixON : Form
    {
        public PixON()
        {
            InitializeComponent();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (fbdSelectPath.ShowDialog() == DialogResult.OK)
            {
                tbPathInput.Text = fbdSelectPath.SelectedPath;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbPathInput.Text))
            {
                lbPathList.Items.Add(tbPathInput.Text);
                tbPathInput.Text = "";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selected = new ListBox.SelectedObjectCollection(lbPathList);
            selected = lbPathList.SelectedItems;
            if (lbPathList.SelectedIndex != -1)
            {
                for (int i = selected.Count - 1; i >= 0; i--)
                {
                    lbPathList.Items.Remove(selected[i]);
                }
            }
        }
    }
}
