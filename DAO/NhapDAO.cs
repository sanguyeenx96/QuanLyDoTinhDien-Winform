using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.DAO
{
    internal class NhapDAO
    {
        private static NhapDAO instance;
        public static NhapDAO Instance
        {
            get { if (instance == null) instance = new NhapDAO(); return NhapDAO.instance; }
            private set { NhapDAO.instance = value; }
        }
        private NhapDAO() { }
        public List<GETNHANSU> LoadTableList_Nhansu(string cell, string ngay, string model)
        {
            List<GETNHANSU> tableList = new List<GETNHANSU>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dotinhdien where cell= '" + cell + "'and ngay='" + ngay + "'and model='" + model + "'");

            foreach (DataRow item in data.Rows)
            {
                GETNHANSU table = new GETNHANSU(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public static int TableWidth = 120;
        public static int TableHeight = 40;


        public DataTable load_chart_soluongdadotinhdien(string model, string begin, string end)
        {
            //string query = string.Format("SELECT ngay, cell, COUNT(ngay) AS Soluongnguoi FROM dotinhdien WHERE(model = '" + model + "' and (ngay  BETWEEN('" + begin + "') AND('" + end + "'))) GROUP BY ngay,cell");
            string query = string.Format("SELECT ngay, COUNT(ngay) AS Soluongnguoi FROM dotinhdien WHERE(model = '" + model + "' and dotinhdien= '1' and (ngay  BETWEEN('" + begin + "') AND('" + end + "'))) GROUP BY ngay  ");
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable load_chart_soluongchuadotinhdien(string model, string begin, string end)
        {
            //string query = string.Format("SELECT ngay, cell, COUNT(ngay) AS Soluongnguoi FROM dotinhdien WHERE(model = '" + model + "' and (ngay  BETWEEN('" + begin + "') AND('" + end + "'))) GROUP BY ngay,cell");
            string query = string.Format("SELECT ngay, COUNT(ngay) AS Soluongnguoi FROM dotinhdien WHERE(model = '" + model + "' and dotinhdien is null and (ngay  BETWEEN('" + begin + "') AND('" + end + "'))) GROUP BY ngay  ");
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

        public DataTable load_chart_tongsoluongnguoi(string model, string begin, string end)
        {
            string query = string.Format("SELECT ngay, COUNT(ngay) AS Tongsoluongnguoi FROM dotinhdien WHERE(model = '" + model + "' and (ngay  BETWEEN('" + begin + "') AND('" + end + "'))) GROUP BY ngay");
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }


        public DataTable chart_cell_songuoidado(string model, string begin, string end,string cell)
        {
            string query = string.Format("SELECT ngay, COUNT(ngay) AS Songuoidado FROM dotinhdien WHERE(model = '" + model + "' and cell ='"+cell+"' and dotinhdien ='1' and (ngay  BETWEEN('" + begin + "') AND('" + end + "'))) GROUP BY ngay");
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable chart_cell_songuoichuado(string model, string begin, string end, string cell)
        {
            string query = string.Format("SELECT ngay, COUNT(ngay) AS Songuoichuado FROM dotinhdien WHERE(model = '" + model + "' and cell ='" + cell + "' and dotinhdien is null and (ngay  BETWEEN('" + begin + "') AND('" + end + "'))) GROUP BY ngay");
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable chart_cell_tongsonguoi(string model, string begin, string end, string cell)
        {
            string query = string.Format("SELECT ngay, COUNT(ngay) AS Tongsonguoi FROM dotinhdien WHERE(model = '" + model + "' and cell ='" + cell + "' and (ngay  BETWEEN('" + begin + "') AND('" + end + "'))) GROUP BY ngay");
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }








    }
}