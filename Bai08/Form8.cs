namespace Bai08
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        
        private void them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sotaikhoan.Text) || string.IsNullOrEmpty(tenkh.Text) || string.IsNullOrEmpty(diachi.Text))
            {
                MessageBox.Show("You have not entered all information !!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(sotien.Text))
                    sotien.Text = "0";
            }
            else 
            {
               
                int stt = listView_show.Items.Count;
                
                ListViewItem danhsach = new ListViewItem();
                danhsach.Text = stt.ToString();
                ListViewItem.ListViewSubItem sotk = new ListViewItem.ListViewSubItem(danhsach, sotaikhoan.Text);
                ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(danhsach, tenkh.Text);
                ListViewItem.ListViewSubItem loc = new ListViewItem.ListViewSubItem(danhsach, diachi.Text);
                ListViewItem.ListViewSubItem price = new ListViewItem.ListViewSubItem(danhsach, sotien.Text);
                
                danhsach.SubItems.Add(sotk);
                danhsach.SubItems.Add(name);
                danhsach.SubItems.Add(loc);
                danhsach.SubItems.Add(price);
                listView_show.Items.Add(danhsach);
                MessageBox.Show("You have successfuly added your account", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                sotaikhoan.Clear();
                tenkh.Clear();
                diachi.Clear();
                sotien.Clear();
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (listView_show.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("You have not selected the item you want to delete", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (listView_show.SelectedIndices.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Are you sure you want to delete?", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    listView_show.Items.Remove(listView_show.SelectedItems[0]);
                    for (int i = 1; i < listView_show.Items.Count; i++)
                    {
                        listView_show.Items[i].SubItems[0].Text = i.ToString();
                    }

                }
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {         
                this.Close();         
        }
    }
}