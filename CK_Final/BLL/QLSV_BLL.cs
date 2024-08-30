using CK_Final.DAL;
using CK_Final.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_Final.BLL
{
    internal class QLSV_BLL
    {
        private static QLSV_BLL _Instance;
        public static QLSV_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLSV_BLL();
                return _Instance;
            }
            private set { }
        }
        public List<CBBItem> GetListCBB_Book()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (Book i in QLSV_DAL.Instance.GetALLBook())
            {
                data.Add(new CBBItem { Text = i.NameSach, Value = i.MaSach });
            }
            return data;
        }
        public List<User> GetListSV(string maSach, string name)
        {
            List<User> data = new List<User>();
            if (maSach == "0" && name == null)
            {
                data = QLSV_DAL.Instance.GetAllUser();
            }
            if (maSach == "0" && name != null)
            {
                data = QLSV_DAL.Instance.GetAllUser().Where(s => s.Name.Contains(name) || s.Books.Any(b=>b.NameSach.Contains(name))).ToList();
            }
            if (maSach != "0" && name != null)
            {
                data = QLSV_DAL.Instance.GetAllUser().Where(s => s.Books.Any(b=>b.MaSach == maSach) && (s.Name.Contains(name) || s.Books.Any(b => b.NameSach.Contains(name)))).ToList();
            }
            if (maSach != "0" && name == null)
            {
                data = QLSV_DAL.Instance.GetAllUser().Where(s => s.Books.Any(b => b.MaSach == maSach)).ToList();
            }
            return data;
        }
        public List<User_View> GetListSV_View(string maSach, string name)
        {
            List<User_View> data = new List<User_View>();
            if (maSach == "0" && name == null)
            {
                data = QLSV_DAL.Instance.GetAllUser_View();
            }
            if (maSach == "0" && name != null)
            {
                data = QLSV_DAL.Instance.GetAllUser_View().Where(s => s.Name.Contains(name) || s.NameSach.Contains(name)).ToList();
            }
            if (maSach != "0" && name != null)
            {
                data = QLSV_DAL.Instance.GetAllUser_View().Where(s => s.MaSach== maSach && (s.Name.Contains(name) || s.NameSach.Contains(name))).ToList();
            }
            if (maSach != "0" && name == null)
            {
                data = QLSV_DAL.Instance.GetAllUser_View().Where(s => s.MaSach == maSach).ToList();
            }
            return data;
        }
        public User GetUserByMSSV(string m)
        {
            User data = null;
            foreach (User i in QLSV_DAL.Instance.GetAllUser())
            {
                if (i.MSSV == m)
                {
                    data = i;
                    break;
                }
            }
            return data;
        }
        public User_View GetUser_ViewByMSSV(string m)
        {
            User_View data = null;
            foreach (User_View i in QLSV_DAL.Instance.GetAllUser_View())
            {
                if (i.MSSV == m)
                {
                    data = i;
                    break;
                }
            }
            return data;
        }
        public void ExcuteDB(User_View s)
        {
            if (GetUserByMSSV(s.MSSV) == null)
            {
                QLSV_DAL.Instance.AddUser(s);
            }
            else
            {
                QLSV_DAL.Instance.EditUser(s);
            }
        }
        public void DelSV(List<string> LDel)
        {
                QLSV_DAL.Instance.DelUser(LDel);
        }
    }
}
