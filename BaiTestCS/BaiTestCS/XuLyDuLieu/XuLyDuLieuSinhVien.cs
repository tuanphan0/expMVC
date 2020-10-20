using BaiTestCS.Models;
using BaiTestCS.Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace BaiTestCS.XuLyDuLieu
{
    public class XuLyDuLieuSinhVien
    {
        public object SqlCammand { get; private set; }

        public XuLyDuLieuSinhVien()
        {

        }

        public List<StudentModel> LayDsSinhVien()
        {
            var content = File.ReadAllText(@"F:\Hoc Tap\Aps.Net MVC\BaiTestCS\BaiTestCS\Models\Json\data.json");
            var students = JsonConvert.DeserializeObject<List<StudentModel>>(content);
            return students;
        }

        public List<StudentSQLModels> getStudentSQL(string ID)
        {
            Connetction db = new Connetction();
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "SELECT * FROM dbo.SinhVien";
            }
            else
            {
                sql = "SELECT * FROM dbo.SinhVien WHERE id =" + ID;
            }
            List<StudentSQLModels> stulist = new List<StudentSQLModels>();
            DataTable dt = new DataTable();
            SqlConnection con = db.getConnection();
            //SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            //da.SelectCommand = new SqlCommand
            //{
            //    CommandText = sql,
            //    Connection
            //};
            da.Fill(dt);
            da.Dispose();
            con.Close();
            StudentSQLModels tmpStu;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tmpStu = new StudentSQLModels();
                tmpStu.ID = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                tmpStu.FullName = dt.Rows[i]["hoten"].ToString();
                tmpStu.Address = dt.Rows[i]["diachi"].ToString();
                tmpStu.BirthDay = dt.Rows[i]["ngaysinh"].ToString();
                tmpStu.Gender = dt.Rows[i]["phai"].ToString();
                stulist.Add(tmpStu);
            }
            return stulist;
        }
        public void Addstudent(StudentSQLModels stu)
        {
            Connetction db = new Connetction();
            string sqL = "INSERT INTO SINHVIEN(DIACHI,NGAYSINH,PHAI,HOTEN) VALUES('" + stu.Address + "','" + stu.BirthDay + "','" + stu.Gender + "','" + stu.FullName + "')";
            SqlConnection con = db.getConnection();
            SqlCommand cmd = new SqlCommand(sqL,con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
            
        }
        public void EditStudents(StudentSQLModels stu)
        {
            string sql = "UPDATE SinhVien SET HOTEN =N'" + stu.Address + "','" + stu.BirthDay + "','" + stu.Gender + "','" + stu.FullName + "' WHERE id=" + stu.ID;
            Connetction db = new Connetction();
            SqlConnection con = db.getConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void DeleteStudents(StudentSQLModels stu)
        {
            string sql = "DELETE SINHVIEN WHERE ID=" + stu.ID;
            Connetction db = new Connetction();
            SqlConnection con = db.getConnection();
            SqlCommand cmd = new SqlCommand(sql,con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}