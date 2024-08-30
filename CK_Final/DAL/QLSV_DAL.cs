using CK_Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_Final.DAL
{
    internal class QLSV_DAL
    {
        private static QLSV_DAL _Instance;
        public static QLSV_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLSV_DAL();
                return _Instance;
            }
            private set { }
        }
        public List<Book> GetALLBook()
        {
            QL_User db = new QL_User();
            var data = db.Books.Select(p=>p).ToList();
            return data;
        }
        public List<User> GetAllUser()
        {
            QL_User db = new QL_User();
            var data = db.Users.Select(p=>p);
            return data.ToList();
        }
        public List<User_View> GetAllUser_View()
        {
            QL_User db = new QL_User();
            var data = db.Users
                   .Join(db.Books,
                         user => user.MSSV,
                         book => book.MSSV,
                         (user, book) => new User_View
                         {
                             MSSV = user.MSSV,
                             Name = user.Name,
                             Gender = user.Gender,
                             NS = user.NS,
                             MaSach = book.MaSach,
                             NameSach = book.NameSach,
                             NgayMuon = book.NgayMuon,
                         })
                   .ToList();
            return data;
        }
        public void AddUser(User_View s)
        {
            QL_User db = new QL_User();
            User newUser = new User
            {
                MSSV = s.MSSV,
                Name = s.Name,
                Gender = s.Gender,
                NS = s.NS,
            };
            Book newBook = new Book
            {
                MaSach = s.MaSach,
                NameSach = s.NameSach,
                NgayMuon = s.NgayMuon,
                MSSV = s.MSSV
            };
            db.Users.Add(newUser);
            db.Books.Add(newBook);
            db.SaveChanges();
        }
        public void EditUser(User_View s)
        {
            QL_User db = new QL_User();
            User user_Edit = db.Users.FirstOrDefault(p => p.MSSV == s.MSSV);
            user_Edit.Name = s.Name;
            user_Edit.Gender = s.Gender;
            user_Edit.NS = s.NS;
            Book user_Edit1 = db.Books.FirstOrDefault(p => p.MSSV == s.MSSV);
            user_Edit1.MaSach = s.MaSach;
            user_Edit1.NameSach = s.NameSach;
            user_Edit1.NgayMuon = s.NgayMuon;
            db.SaveChanges();
        }
        public void DelUser(List<string> s)
        {
            QL_User db = new QL_User();
            var user_Del1 = db.Books.Where(p => s.Contains(p.MSSV)).ToList();
            var user_Del = db.Users.Where(p => s.Contains(p.MSSV)).ToList();
            db.Users.RemoveRange(user_Del);
            db.Books.RemoveRange(user_Del1);
            db.SaveChanges();
        }
    }
}
