using System.Windows.Forms;

namespace Bai09
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {

        }

        string gioitinh = "";
        int somon = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.AppendText(richTextBox1.SelectedText);
            richTextBox2.AppendText("\n");
            richTextBox1.SelectedText = "";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(richTextBox2.SelectedText);
            richTextBox1.AppendText("\n");
            richTextBox2.SelectedText = "";
            
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count <= 1)
            {
                MessageBox.Show("You have not selected the member you want to delete", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dataGridView.Rows.Count > 1)
            {
                DialogResult dl = MessageBox.Show("Are you sure you want to delete?", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
                }
            }
        }

        private void luu_Click(object sender, EventArgs e)
        {
            ktgioitinh();
            somon = richTextBox2.Lines.Count() - 1;
            if (string.IsNullOrEmpty(msv.Text) || string.IsNullOrEmpty(hoten.Text) || string.IsNullOrEmpty(chuyennganh.Text))
            {
                MessageBox.Show("You have not entered full information !!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.Rows.Add(msv.Text, hoten.Text, chuyennganh.SelectedItem, gioitinh, somon);
                MessageBox.Show("Data successfuly added !", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                msv.Clear();
                hoten.Clear();
                chuyennganh.Controls.Clear();
                richTextBox1.AppendText( richTextBox2.Text);
                richTextBox2.Text = "";
            }

        }

        private void ktgioitinh()
        {
            if (gt_Nam.Checked == true && gt_Nu.Checked == false)
                gioitinh = "Nam";
            else if (gt_Nu.Checked == true && gt_Nam.Checked == false)
                gioitinh = "Nữ";
            else if (gt_Nu.Checked = true && gt_Nam.Checked == true)
                MessageBox.Show("Chọn 1 trong 2", "Lỗi giới tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}