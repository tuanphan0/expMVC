using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BaiTestCS.Models.SQL;
namespace BaiTestCS.Models.SQL.Dao
{
    public class UesrDao
    {
        QLDongHo db = null;
        public UesrDao()
        {
            db = new QLDongHo();
        }
        public long Insert(tbl_KhachHang entity)
        {
            db.tbl_KhachHang.Add(entity);
            db.SaveChanges();
            return entity.MaKhachHang;
        }
        public tbl_KhachHang GetId(String userName)
        {
            return db.tbl_KhachHang.SingleOrDefault(x => x.TenDangNhap == userName);
        }
        public bool Login(String userName, string passWord)
        {
            var result = db.tbl_KhachHang.Count(x => x.TenDangNhap == userName && x.MatKhau == passWord);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}