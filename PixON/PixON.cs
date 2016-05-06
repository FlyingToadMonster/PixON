using System;
using System.IO;
using System.Windows.Forms;

namespace PixON
{
    public partial class PixON : Form
    {
        private QuickBar qb;

        KeyboardHook hook = new KeyboardHook();

        public PixON()
        {
            InitializeComponent();

            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(ModKeys.Control | ModKeys.Alt, Keys.I);

            qb = new QuickBar();
            qb.mainForm = this;
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            PicOp.ImportClipboard();
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

        private void PixON_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                Hide();
            }
            else if (WindowState == FormWindowState.Normal)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
