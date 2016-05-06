using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PixON
{
    public struct Pic
    {
        public string hash;
        public string title;
        public string path;
        public int index;
    }

    public partial class QuickBar : Form
    {
        internal PixON mainForm;
        private int offsetX;
        private int offsetY;
        private bool isMoving;
        Pic[] recentPic = new Pic[20];

        KeyboardHook hook = new KeyboardHook();

        public QuickBar()
        {
            InitializeComponent();
            
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(ModKeys.Control | ModKeys.Alt, Keys.K);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            Show();
            Activate();
            searchBox.Focus();
        }

        private void QuickBar_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void menuQuickBarShowMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void iconBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void iconBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - offsetX;
                Top += e.Y - offsetY;
                isMoving = true;
            }
        }

        private void iconBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isMoving)
                {
                    isMoving = false;
                }
                /*
                else if (searchBox.Visible)
                {
                    searchBox.Hide();
                    recentBox.Hide();
                    resultBox.Hide();
                }
                */
                else
                {
                    searchBox.Text = "";
                    recentBox.ClearSelected();
                    resultBox.Items.Clear();
                    foreach (Pic item in recentPic)
                    {
                        // TODO: 在输入或选择搜索词前，resultBox显示最近使用过的图片
                        //resultBox.Items.Add(item.title, item.)
                    }
                    // TODO: 每次搜索选定图片时，认为搜索词已经确定了，将其添加到历史搜索词中
                    /*
                    searchBox.Show();
                    recentBox.Show();
                    resultBox.Show();
                    */
                }
            }
        }

        private void recentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Text = (string)recentBox.SelectedItem;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            PixONDb picDb = new PixONDb();
            HashSet<string> resultText = picDb.GetFile(searchText);
            resultImageList.Images.Clear();
            resultBox.Clear();
            if (resultText != null)
            {
                List<string> pathList = new List<string>();
                foreach (string path in resultText)
                {
                    resultImageList.Images.Add(Image.FromFile(path));
                    resultBox.View = View.LargeIcon;
                    resultImageList.ImageSize = new Size(64, 64);
                    resultBox.LargeImageList = resultImageList;
                    pathList.Add(path);
                }
                for (int i = 0; i < resultImageList.Images.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Name = pathList[i];
                    resultBox.Items.Add(item);
                }
            }
        }

        private void resultBox_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetImage(Image.FromFile(resultBox.SelectedItems[0].SubItems[0].Name));
            Hide();
            SendKeys.SendWait("^v");
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (resultBox.Items.Count > 0)
                {
                    Clipboard.SetImage(Image.FromFile(resultBox.Items[0].SubItems[0].Name));
                    Hide();
                    SendKeys.SendWait("^v");
                }
            }
        }
    }
}
