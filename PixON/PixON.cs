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

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void menuTrayShowMain_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void menuTrayExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
