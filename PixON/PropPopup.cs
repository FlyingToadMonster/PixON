﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PixON
{
    public partial class PropPopup : Form
    {
        public string imgMD5;
        public string fileName;

        public PropPopup()
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
            picDb.DelProp(imgMD5);
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
