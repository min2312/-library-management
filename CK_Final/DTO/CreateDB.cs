using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_Final.DTO
{
    internal class CreateDB: DropCreateDatabaseAlways<QL_User>
    {
        protected override void Seed(QL_User context)
        {
            context.Users.AddRange(new User[]
            {
                new User{ MSSV = "102220329", Name = "Minh",NS = Convert.ToDateTime("01/07/2004"),Gender = true},
                new User{ MSSV = "102220328", Name = "Toàn",NS = Convert.ToDateTime("02/06/2004"),Gender = true},
                new User{ MSSV = "102220327", Name = "Phước",NS = Convert.ToDateTime("03/05/2004"),Gender = true},
                new User{ MSSV = "1022203219", Name = "Hoàng",NS = Convert.ToDateTime("04/04/2004"),Gender = false},
            });

            context.Books.AddRange(new Book[]
            {
                new Book{ MaSach ="01", NameSach = "Sách java",NgayMuon = Convert.ToDateTime("16/06/2024"),MSSV = "102220329"},
                new Book{ MaSach = "02", NameSach = "Sách .Net",NgayMuon = Convert.ToDateTime("01/06/2024"),MSSV = "102220327"},
                new Book{ MaSach = "03", NameSach = "Sách OOP",NgayMuon = Convert.ToDateTime("01/05/2024"),MSSV = "102220328"},
                new Book{ MaSach = "04", NameSach = "Sách Python",NgayMuon = Convert.ToDateTime("11/05/2024"),MSSV = "1022203219"},
                new Book{ MaSach = "05", NameSach = "Sách C++",NgayMuon = Convert.ToDateTime("21/04/2024"),MSSV = "102220329"}
            });
        }
    }
}
