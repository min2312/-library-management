using CK_Final.BLL;
using CK_Final.DTO;
using CK_Final.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_Final
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateDB();
            SetCBB_Book();
            SetCBB_Sort();
        }
        public void SetCBB_Book()
        {
            cbb_Book.Items.Add(new CBBItem { Value = "0", Text = "ALL" });
            cbb_Book.Items.AddRange(QLSV_BLL.Instance.GetListCBB_Book().ToArray());
        }
        public void SetCBB_Sort()
        {
            var properties = typeof(User_View).GetProperties().Select(p => p);
            foreach (var property in properties)
            {
               comboBox2.Items.Add(property.Name);
            }
        }
        public void CreateDB()
        {
            QL_User qLUser = new QL_User();
            ShowDGV("0", null);
        }
        private void ShowDGV(string maSach, string name)
        {
            dataGridView1.DataSource = QLSV_BLL.Instance.GetListSV_View(maSach, name);
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            if(cbb_Book.SelectedIndex >= 0) 
            {
                string MaSach = ((CBBItem)cbb_Book.SelectedItem).Value;
                ShowDGV(MaSach, txt_Search.Text);
            }
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            DetailForm df = new DetailForm();
            df.d += new DetailForm.Mydel(ShowDGV);
            df.Show();
        }

        private void but_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MSSV = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
                DetailForm df = new DetailForm(MSSV);
                df.d += new DetailForm.Mydel(ShowDGV);
                df.Show();
            }
        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                List<string> LMSSV = new List<string>();
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    LMSSV.Add(i.Cells["MSSV"].Value.ToString());
                }
                QLSV_BLL.Instance.DelSV(LMSSV);
                ShowDGV("0", null);
            }
        }
        private void but_Sort_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                string maSach = ((CBBItem)cbb_Book.SelectedItem).Value;
                List<User_View> svList = QLSV_BLL.Instance.GetListSV_View(maSach,txt_Search.Text);
                switch (comboBox2.Text)
                {
                    case "MSSV":
                        svList.Sort((x, y) => string.Compare(x.MSSV, y.MSSV));
                        break;
                    case "Name":
                        svList.Sort((x, y) => string.Compare(x.Name, y.Name));
                        break;
                    case "Gender":
                        svList.Sort((x, y) => x.Gender.CompareTo(y.Gender));
                        break;
                    case "NS":
                        svList.Sort((x, y) => x.NS.CompareTo(y.NS));
                        break;
                    case "MaSach":
                        svList.Sort((x, y) => string.Compare(x.MaSach, y.MaSach));
                        break;
                    case "NameSach":
                        svList.Sort((x, y) => string.Compare(x.NameSach, y.NameSach));
                        break;
                    case "NgayMuon":
                        svList.Sort((x, y) => x.NgayMuon.CompareTo(y.NgayMuon));
                        break;
                    default:
                        break;
                }
                dataGridView1.DataSource = svList;
            }
        }
    }
}
