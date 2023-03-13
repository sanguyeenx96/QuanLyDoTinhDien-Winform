using DXApplication1.DAO;
using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Helpers.FindSearchRichParser;

namespace DXApplication1
{
    public partial class FormThongke : Form
    {
        public FormThongke()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }
       
        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            text_tongsonguoi.Text = "0";
            text_dado.Text = "0";
            text_chuado.Text = "0";
            text_hoten.Text = "";
            text_chucvu.Text = "";
            text_congdoan.Text = "";
            text_maid.Text = "";

            int chuadotinhdien = 0;
            int dadotinhdien = 0;

            flowLayoutPanel1.Controls.Clear();
            text_ngay.Text = dateNavigator1.DateTime.ToString("dd/MM/yyyy");
            text_model.Text = comboBoxEdit1.Text;
            text_cell.Text = comboBoxEdit2.Text;

            string cell = comboBoxEdit2.Text;
            string ngay = dateNavigator1.DateTime.ToString("yyyy/MM/dd");
            string model = comboBoxEdit1.Text;
            text_tongsonguoi.Text = ((int)DataProvider.Instance.ExecuteScalar("SELECT COUNT (*) FROM dotinhdien where cell= '" + cell + "'and ngay='" + ngay + "'and model='" + model + "'")).ToString() + " người";
            List<GETNHANSU> tableList1 = NhapDAO.Instance.LoadTableList_Nhansu(cell, ngay, model);
            foreach (GETNHANSU item in tableList1)
            {
                string maid = item.Macode;
                string date = dateNavigator1.DateTime.ToString("yyyy/MM/dd");
                DataTable trangthaidotinhdien = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.dotinhdien WHERE macode='" + maid + "' AND ngay='" + date + "'");
                string trangthai = trangthaidotinhdien.Rows[0][14].ToString();

                if (trangthai=="1")
                {
                    dadotinhdien++;
                    Button btn = new Button() { Width = NhapDAO.TableWidth, Height = NhapDAO.TableHeight };
                    btn.Text = item.Station + " : " + item.Chucvu + Environment.NewLine + item.Hoten;
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.White;
                    btn.Click += btn_Click;
                    btn.Tag = item;
                    flowLayoutPanel1.Controls.Add(btn);
                    text_dado.Text = dadotinhdien.ToString() + " người";
                }
                if (trangthai == "")
                {
                    chuadotinhdien++;
                    Button btn = new Button() { Width = NhapDAO.TableWidth, Height = NhapDAO.TableHeight };
                    btn.Text = item.Station + " : " + item.Chucvu + Environment.NewLine + item.Hoten;
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.White;
                    btn.Click += btn_Click;
                    btn.Tag = item;
                    flowLayoutPanel1.Controls.Add(btn);
                    text_chuado.Text = chuadotinhdien.ToString() + " người";
                }
            }
        }
        int ck = 0;
        void btn_Click(object sender, EventArgs e)
        {
            if (ck == 0)
            {
                ck = 1;
            }
            if (ck == 1)
            {
                string hoten = ((sender as Button).Tag as GETNHANSU).Hoten;
                string chucvu = ((sender as Button).Tag as GETNHANSU).Chucvu;
                string congdoan = ((sender as Button).Tag as GETNHANSU).Station;
                string maid = ((sender as Button).Tag as GETNHANSU).Macode;

                text_hoten.Text = hoten;
                text_chucvu.Text = chucvu;
                text_congdoan.Text = congdoan;
                text_maid.Text = maid;
            }
        }

        private void simpleButton1_Click1(object sender, EventArgs e)
        {

        }
    }
}
