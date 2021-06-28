using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class Connection
    {
        protected string connectionString;
        protected SqlConnection cnn;
        public void Connect()
        {
            connectionString = "Data Source=MAYTINH-4ITD0P9;Initial Catalog=sql_btl_asp;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }
        public List<HangMayBay> GetALLHMB()
        {
            Connect();
            List<HangMayBay> hangMayBays = new List<HangMayBay>();
            String sql = "SELECT * FROM HangMayBay";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataReader data = com.ExecuteReader();
            while (data.Read())
            {
                hangMayBays.Add(new HangMayBay(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4)));
            }
            return hangMayBays;
        }
        public List<DatVe> GetALLDV()
        {
            Connect();
            List<DatVe> datVe = new List<DatVe>();
            String sql = "SELECT * FROM DatVe";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataReader data = com.ExecuteReader();
            while (data.Read())
            {
                datVe.Add(new DatVe(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4)));
            }
            return datVe;    
        }
        public List<ThongTinVe> GetALLTTV()
        {
            Connect();
            List<ThongTinVe> thongTinVe = new List<ThongTinVe>();
            String sql = "SELECT * FROM ThongTinVe";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataReader data = com.ExecuteReader();
            while (data.Read())
            {
                thongTinVe.Add(new ThongTinVe(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetInt32(3), data.GetDateTime(4), data.GetString(5), data.GetDateTime(6), data.GetString(7)));
            }
            return thongTinVe;
        }
        public HangMayBay GetHangMayBay(int ID)
        {
            HangMayBay hangMayBay = null;
            Connect();
            String sql = "SELECT * FROM HangMayBay WHERE ID = '" + ID + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmm.ExecuteReader();
            while (reader.Read())
            {
                hangMayBay = new HangMayBay(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
            }
            cnn.Close();
            return hangMayBay;
        }
        public Boolean updateHMB(HangMayBay cb)
        {
            Connect();
            string sql = "UPDATE HangMayBay SET code = '" + cb.CODE
                + "', name_h = '" + cb.NAME + "', address_h = '" + cb.ADDRESS
                + "', phone_h = '" + cb.PHONE + "' WHERE ID = '" + cb.ID + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean insertHMB(HangMayBay cb)
        {
            Connect();
            int id = GetALLHMB()[GetALLHMB().Count - 1].ID + 1;
            string sql = "INSERT INTO HangMayBay (ID, code, name_h, address_h, phone_h) VALUES ('" + id + "', '" + cb.CODE
                + "', '" + cb.NAME + "', '" + cb.ADDRESS
                + "', '" + cb.PHONE + "')";
            Connect();
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean deleteHMB(int ID)
        {
            Connect();
            string sql = "DELETE FROM HangMayBay WHERE ID = '" + ID + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DatVe GetDatVe(int ID)
        {
            DatVe datVe = null;
            Connect();
            String sql = "SELECT * FROM DatVe WHERE ID = '" + ID + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmm.ExecuteReader();
            while (reader.Read())
            {
                datVe = new DatVe(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
            }
            cnn.Close();
            return datVe;
        }
        public Boolean updateDV(DatVe cb)
        {
            Connect();
            string sql = "UPDATE DatVe SET code_v = '" + cb.CODE
                + "', name_kh = '" + cb.NAME + "', id_card = '" + cb.IDCARD
                + "', phone_kh = '" + cb.PHONE + "' WHERE ID = '" + cb.ID + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean insertDV(DatVe cb)
        {
            Connect();
            int id = GetALLDV()[GetALLDV().Count - 1].ID + 1;
            string sql = "INSERT INTO DatVe (ID, code_v, name_kh, id_card, phone_kh) VALUES ('" + id + "', '"+ cb.CODE
                + "', '" + cb.NAME + "', '" + cb.IDCARD
                + "', '" + cb.PHONE + "')";
            Connect();
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean deleteDV(int ID)
        {
            Connect();
            string sql = "DELETE FROM DatVe WHERE ID = '" + ID + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public ThongTinVe GetThongTinVe(int ID)
        {
            ThongTinVe hangMayBay = null;
            Connect();
            String sql = "SELECT * FROM ThongTinVe WHERE ID = '" + ID + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmm.ExecuteReader();
            while (reader.Read())
            {
                hangMayBay = new ThongTinVe(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetDateTime(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7));
            }
            cnn.Close();
            return hangMayBay;
        }
        public Boolean updateTTV(ThongTinVe cb)
        {
            Connect();
            string sql = "UPDATE ThongTinVe SET code_v = '" + cb.CODE
                + "', type_v = '" + cb.TYPE + "', price_v = '" + cb.PRICE
                + "', datetime_start = '" + cb.DT_START + "', point_start = '" + cb.POINT_START + "', datetime_end = '" + cb.DT_END
                + "', point_end = '" + cb.POINT_END + "' WHERE ID = '" + cb.ID + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean insertTTV(ThongTinVe cb)
        {
            Connect();
            int id = GetALLTTV()[GetALLTTV().Count - 1].ID + 1;
            string sql = "INSERT INTO ThongTinVe (ID, code_v, type_v, price_v, datetime_start, point_start, datetime_end, point_end) VALUES ('" + id + "', '" + cb.CODE + "', '" + cb.TYPE + "', '" + cb.PRICE + "', '" + cb.DT_START + "', '" + cb.POINT_START + "', '" + cb.DT_END + "', '" + cb.POINT_END + "')";
            Connect();
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean deleteTTV(int ID)
        {
            Connect();
            string sql = "DELETE FROM ThongTinVe WHERE ID = '" + ID + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}