using DevExpress.Data.Filtering.Helpers;
using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    internal class Functions
    {
        //   SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
        public void OpenAndClose()
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
            } 
                
        }
        public bool Login(string tk, string mk)
        {
            OpenAndClose();
            string sqlLogin = "select * from TaiKhoan where MaNV = @tk and MatKhau = @mk";
            SqlCommand cmd = new SqlCommand(sqlLogin, conn);
            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.Parameters.AddWithValue("@mk", mk);
            SqlDataReader dta = cmd.ExecuteReader();
            bool LoginCheck = dta.HasRows;
            OpenAndClose();
            return LoginCheck;
        }

        // Hàm sử dụng cho cơ sở dữ liệu tạm
        //Begin 

        public void TempAccount(string tk)
        {
            OpenAndClose();
            string Query = "insert into dbo.BoNhoTam (MaNV) values (@tk)";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.ExecuteNonQuery();
            OpenAndClose();
        }
        public string SelectTemp()
        {
            OpenAndClose();
            string QuerySelectMaNV = "select MaNV from dbo.BoNhoTam ";
            SqlCommand cmd = new SqlCommand(QuerySelectMaNV, conn);
            object GetMaNV = cmd.ExecuteScalar();
            OpenAndClose();
            string MaNV = Convert.ToString(GetMaNV);
            return MaNV;
        }
        public void DeleteTemp()
        {
            OpenAndClose();
            string QueryDelete = "delete from  dbo.BoNhoTam";
            SqlCommand cmd = new SqlCommand(QueryDelete, conn);
            cmd.ExecuteNonQuery();
            OpenAndClose();
        }

        //End
        public void ErrorWarning(ErrorProvider error, TextBox txt, string message)
        {
            error.SetError(txt, message);
            txt.Focus();
        }
        public void clear_whitespace(TextBox[] NameTxt)
        {
            Regex trimmer = new Regex(@"\s\s+"); // Xoá khoảng trắng thừa trong chuỗi 
            foreach(TextBox txt in NameTxt)
            {
                txt.Text=txt.Text.Trim();
                txt.Text = trimmer.Replace(txt.Text, " ");
            }
        }

        public object Select_TblNhanVien(string str)
        {
            string MaNV = SelectTemp();
            string Query = $"Select {str} from dbo.NhanVien where MaNV = @MaNV";
            OpenAndClose();
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            object GetData = cmd.ExecuteScalar();
            OpenAndClose();
            return GetData;
        }
        public bool Select_TblCheck(string field1, string tbl, string field2, string value)
        {
            OpenAndClose();
            string Query = $"Select {field1} from {tbl} where {field2} = @value";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@value", value);
            SqlDataReader dta = cmd.ExecuteReader();
            bool CheckData = dta.HasRows;
            OpenAndClose();
            return CheckData;
        }
        public bool Select_TblChecks(string field,string tbl, string[] Fieldcondition, SqlParameter[] parametersCondition)
        {
            string query = $"Select {field} from {tbl} where ";
            for(int i=0; i<Fieldcondition.Length;i++)
            {
                query += $"{Fieldcondition[i]} = {parametersCondition[i].ParameterName} and ";
            }
            query = query.Substring(0,query.Length-4);
            OpenAndClose();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parametersCondition);
            SqlDataReader dta = cmd.ExecuteReader();
            bool CheckData = dta.HasRows;
            cmd.Parameters.Clear();
            OpenAndClose();
            return CheckData;
        }
        public object Select_GetValue(string field1, string tbl, string field2, string value)
        {
            OpenAndClose();
            string Query = $"Select {field1} from {tbl} where {field2} = @value";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@value", value);
            object GetData = cmd.ExecuteScalar();
            OpenAndClose();
            return GetData;
        }
        public object Select_GetValues(string field, string tbl, string[] FieldCondition , SqlParameter[] parametersCondition)
        {
            string query = $"Select {field} from {tbl} where ";
            for(int i=0;i<FieldCondition.Length;i++)
            {
                query += $"{FieldCondition[i]} = {parametersCondition[i].ParameterName} and ";
            }
            query = query.Substring(0, query.Length - 4);
            OpenAndClose();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parametersCondition);
            object GetData = cmd.ExecuteScalar();
            cmd.Parameters.Clear ();
            OpenAndClose();
            return GetData;
        }

        public DataTable Select(string QuerrySelect)
        {
            OpenAndClose();
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            OpenAndClose();
            return dt;
        }

        public DataTable ReadData(string tbl,string field,string value)
        {
            OpenAndClose();
            string Query = $"Select * from {tbl} where {field} = @value";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@value", value);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            OpenAndClose();
            return dt;
        }
        public void InsertDataIntoTable(string tblData, SqlParameter[] parameters)
        {
            string query = $"INSERT INTO {tblData} VALUES (";

            for (int i = 0; i < parameters.Length; i++)
            {
                query += $"{parameters[i].ParameterName},";
            }

            query = query.TrimEnd(',') + ")";
            OpenAndClose();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            OpenAndClose();
        }
        public void UpdateDataTable(string tbl,string[] field , SqlParameter[] parameters, string[] FieldCondition, SqlParameter[] parametersCondition)
        {
            string query = $"Update {tbl} set ";
            for(int i = 0; i < field.Length; i++)
            {
                query += $"{field[i]} = {parameters[i].ParameterName},";
            }
            query = query.TrimEnd(',') + " where ";
            for (int i = 0; i < FieldCondition.Length; i++)
            {
                query += $"{FieldCondition[i]} = {parametersCondition[i].ParameterName} and ";
            }
            query = query.Substring(0,query.Length-4);
            OpenAndClose();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);
            cmd.Parameters.AddRange(parametersCondition);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            OpenAndClose();
        }
        public void DeleteDataTable(string tbl,string[] fieldCondition, SqlParameter[] parametersCondition)
        {
            string query = $"Delete from {tbl} where ";
            for(int i=0;i < fieldCondition.Length;i++)
            {
                query += $"{fieldCondition[i]} = {parametersCondition[i].ParameterName} and ";
            }
            query = query.Substring(0, query.Length - 4);
            OpenAndClose();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parametersCondition);
            cmd.ExecuteNonQuery();
            OpenAndClose();
        }
        public DataTable SelectCondition(string tbl, string[] fieldCondition, SqlParameter[] parametersCondition)
        {
            string query = $"Select * from {tbl} where ";
            for(int i = 0 ; i < fieldCondition.Length;i++)
            {
                query += $"{fieldCondition[i]} LIKE {parametersCondition[0].ParameterName} or ";
            }
            query = query.Substring(0, query.Length - 3);
            OpenAndClose();
            SqlCommand cmd = new SqlCommand (query, conn);
            cmd.Parameters.AddRange (parametersCondition);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            OpenAndClose();
            return dt;
        }
    }
}
