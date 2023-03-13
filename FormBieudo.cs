using DevExpress.Charts.Native;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;
using DXApplication1.DAO;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace DXApplication1
{
    public partial class FormBieudo : Form
    {
        public FormBieudo()
        {
            InitializeComponent();
        }

  
        void loadChart()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chartControl1.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.load_chart_soluongdadotinhdien(model, begin, end);
            chartControl1.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chartControl1.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Soluongnguoi";
            chartControl1.Series["Đã đo tĩnh điện"].SeriesPointsSorting = SortingMode.Descending;

            chartControl1.Series["Tổng số người"].DataSource = NhapDAO.Instance.load_chart_tongsoluongnguoi(model, begin, end);
            chartControl1.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chartControl1.Series["Tổng số người"].ValueDataMembers[0] = "Tongsoluongnguoi";

            chartControl1.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.load_chart_soluongchuadotinhdien(model, begin, end);
            chartControl1.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chartControl1.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Soluongnguoi";
        }

        void loadChart3()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chartControl2.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end,"1");
            chartControl2.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chartControl2.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chartControl2.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "1");
            chartControl2.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chartControl2.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chartControl2.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "1");
            chartControl2.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chartControl2.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";
        }
        void loadChart4()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chartControl3.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end, "2");
            chartControl3.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chartControl3.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chartControl3.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "2");
            chartControl3.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chartControl3.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chartControl3.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "2");
            chartControl3.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chartControl3.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";

        }
        void loadChart_cell3()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chart_cell3.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end, "3");
            chart_cell3.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell3.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chart_cell3.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "3");
            chart_cell3.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell3.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chart_cell3.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "3");
            chart_cell3.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chart_cell3.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";
        }
        void loadChart_cell4()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chart_cell4.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end, "4");
            chart_cell4.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell4.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chart_cell4.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "4");
            chart_cell4.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell4.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chart_cell4.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "4");
            chart_cell4.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chart_cell4.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";
        }
        void loadChart_cell5()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chart_cell5.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end, "5");
            chart_cell5.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell5.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chart_cell5.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "5");
            chart_cell5.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell5.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chart_cell5.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "5");
            chart_cell5.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chart_cell5.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";
        }
        void loadChart_cell6()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chart_cell6.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end, "6");
            chart_cell6.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell6.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chart_cell6.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "6");
            chart_cell6.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell6.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chart_cell6.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "6");
            chart_cell6.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chart_cell6.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";
        }
        void loadChart_cell7()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chart_cell7.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end, "7");
            chart_cell7.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell7.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chart_cell7.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "7");
            chart_cell7.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell7.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chart_cell7.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "7");
            chart_cell7.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chart_cell7.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";
        }
        void loadChart_cell8()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chart_cell8.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end, "8");
            chart_cell8.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell8.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chart_cell8.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "8");
            chart_cell8.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell8.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chart_cell8.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "8");
            chart_cell8.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chart_cell8.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";
        }
        void loadChart_cell9()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chart_cell9.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end, "9");
            chart_cell9.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell9.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chart_cell9.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "9");
            chart_cell9.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell9.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chart_cell9.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "9");
            chart_cell9.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chart_cell9.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";
        }
        void loadChart_cell10()
        {
            string model = cb_model.Text;
            string begin = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string end = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            chart_cell10.Series["Đã đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoidado(model, begin, end, "10");
            chart_cell10.Series["Đã đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell10.Series["Đã đo tĩnh điện"].ValueDataMembers[0] = "Songuoidado";

            chart_cell10.Series["Chưa đo tĩnh điện"].DataSource = NhapDAO.Instance.chart_cell_songuoichuado(model, begin, end, "10");
            chart_cell10.Series["Chưa đo tĩnh điện"].ArgumentDataMember = "ngay";
            chart_cell10.Series["Chưa đo tĩnh điện"].ValueDataMembers[0] = "Songuoichuado";

            chart_cell10.Series["Tổng số người"].DataSource = NhapDAO.Instance.chart_cell_tongsonguoi(model, begin, end, "10");
            chart_cell10.Series["Tổng số người"].ArgumentDataMember = "ngay";
            chart_cell10.Series["Tổng số người"].ValueDataMembers[0] = "Tongsonguoi";
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            loadChart();
            loadChart3();
            loadChart4();
            loadChart_cell3();
            loadChart_cell4();
            loadChart_cell5();
            loadChart_cell6();
            loadChart_cell7();
            loadChart_cell8();
            loadChart_cell9();
            loadChart_cell10();
        }
    }
}
