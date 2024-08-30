using CK_Final.BLL;
using CK_Final.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_Final.View
{
    public partial class DetailForm : Form
    {
        private string MSSV;
        public delegate void Mydel(string maSach, string name);
        public Mydel d { get; set; }
        public DetailForm(string m=null)
        {
            InitializeComponent();
            MSSV = m;
            SetCBB();
            SetGUI();
        }
        public void SetCBB()
        {
            Cbb_Book.Items.AddRange(QLSV_BLL.Instance.GetListCBB_Book().ToArray());
        }
        public void SetGUI()
        {
            if (QLSV_BLL.Instance.GetUserByMSSV(MSSV) != null)
            {
                txt_MSSV.ReadOnly = true;
                User_View data = QLSV_BLL.Instance.GetUser_ViewByMSSV(MSSV);
                txt_MSSV.Text = MSSV;
                txt_Name.Text = data.Name.ToString();
                Cbb_Book.Text = data.NameSach.ToString();
                dateTimePicker1.Text = data.NgayMuon.ToString();
                if (data.Gender)
                {
                    Rb_Male.Checked = true;
                    Rb_Female.Checked = false;
                }
                else
                {
                    Rb_Male.Checked = false;
                    Rb_Female.Checked = true;
                }
            }
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void but_Ok_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (User_View i in QLSV_BLL.Instance.GetListSV_View("0", null))
            {
                if (i.MSSV == txt_MSSV.Text)
                {
                    check = true;
                    break;
                }
            }
            if (check && MSSV == null)
            {
                MessageBox.Show("Đã tồn tại MSSV");
            }
            else
            {
                string selectedBook = Cbb_Book.SelectedItem != null ? Cbb_Book.SelectedItem.ToString() : Cbb_Book.Text;
                string masach = Cbb_Book.SelectedItem!=null?((CBBItem)Cbb_Book.SelectedItem).Value : Cbb_Book.Text;
                User_View s = new User_View
                {
                    MSSV = txt_MSSV.Text,
                    Name = txt_Name.Text,
                    NameSach = selectedBook,
                    MaSach = masach,
                    NS = dtp_NS.Value,
                    Gender = Rb_Male.Checked ? true : false,
                    NgayMuon = dateTimePicker1.Value,
                };
                QLSV_BLL.Instance.ExcuteDB(s);
                d("0", null);
                this.Dispose();
            }
        }
    }
}
