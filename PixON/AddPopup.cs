using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PixON
{
    public partial class AddPopup : Form
    {
        public string imgMD5;
        public string fileName;

        public AddPopup()
        {
            InitializeComponent();
        }

        private void AddPopup_Shown(object sender, EventArgs e)
        {
            PixONDb picDb = new PixONDb();
            pbPreview.Image = Image.FromFile(fileName);

            List<List<string>> fileProp = picDb.GetProp(imgMD5);
            foreach (List<string> item in fileProp)
            {
                dgvKeyValue.Rows.Add(new object[] { item[0], item[1] });
            }
            picDb.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PixONDb picDb = new PixONDb();
            foreach (DataGridViewRow row in dgvKeyValue.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string key = row.Cells[0].Value.ToString();
                    string value = row.Cells[1].Value.ToString();
                    if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                    {
                        picDb.AddProp(imgMD5, key, value);
                    }
                }
            }
            Close();
            picDb.Close();
        }
    }
}
