using System;
using System.Windows.Forms;

namespace PixON
{
    public partial class AddPopup : Form
    {
        public string imgMD5;

        public AddPopup()
        {
            InitializeComponent();
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
            picDb.Close();
            Close();
        }
    }
}
