using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    internal class Function
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
    }
    public bool Login(string tk, string mk)
    {
        conn.Open();
        string sqlLogin = "select * from TaiKhoan where MaNV = @tk and MatKhau = @mk";
        SqlCommand cmd = new SqlCommand(sqlLogin, conn);
        cmd.Parameters.AddWithValue("@tk", tk);
        cmd.Parameters.AddWithValue("@mk", mk)
        SqlDataReader dta = cmd.ExecuteReader();
        bool LoginCheck = dta.HasRows;
        conn.Close();
        return LoginCheck;
    }
    public void TempAccount (string tk)
    {
        conn.Open();
        string Querry = "insert into dbo.BoNhoTam (MaNV) values (@tk)";
        SqlCommand cmd = new SqlCommand(Querry, conn);
        cmd.Parameters.AddWithValue("@tk", tk);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}
