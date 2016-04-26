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

        public QuickBar()
        {
            InitializeComponent();
        }

        private void QuickBar_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
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
                else if (searchBox.Visible)
                {
                    searchBox.Hide();
                    recentBox.Hide();
                    resultBox.Hide();
                }
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
                    searchBox.Show();
                    recentBox.Show();
                    resultBox.Show();
                }
            }
        }

        private void recentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Text = (string)recentBox.SelectedItem;
        }
    }
}
