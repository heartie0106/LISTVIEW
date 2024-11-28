using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLN.Text) || string.IsNullOrWhiteSpace(txtFN.Text) || string.IsNullOrWhiteSpace(txtP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm dữ liệu vào ListView
            var item = new ListViewItem(txtLN.Text);
            item.SubItems.Add(txtFN.Text);
            item.SubItems.Add(txtP.Text);
            lv1.Items.Add(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa mục được chọn
            if (lv1.SelectedItems.Count > 0)
            {
                lv1.Items.Remove(lv1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)
            {
                var selectedItem = lv1.SelectedItems[0];

                if (!string.IsNullOrWhiteSpace(txtLN.Text))
                    selectedItem.SubItems[0].Text = txtLN.Text;

                if (!string.IsNullOrWhiteSpace(txtFN.Text))
                    selectedItem.SubItems[1].Text = txtFN.Text;

                if (!string.IsNullOrWhiteSpace(txtP.Text))
                    selectedItem.SubItems[2].Text = txtP.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
