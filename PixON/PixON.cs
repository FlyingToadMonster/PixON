using System;
using System.IO;
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

        private void btnQBar_Click(object sender, EventArgs e)
        {
            qb.Show();
        }

        private void btnClipImp_Click(object sender, EventArgs e)
        {
            PicOp.ImportClipboard();
        }
    }
}
