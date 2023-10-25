using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyMonHoc
{
    public partial class Form1 : Form
    {
        string strketnoi=@"Data Source=A209PC02;Initial Catalog=QL_MonHoc; Integrated Security=True";
        SqlConnection sqlketnoi = null;
        public Form1()
        {
            InitializeComponent();
            try
            {
                if (sqlketnoi == null)
                {
                    sqlketnoi = new SqlConnection(strketnoi);
                }
                if (sqlketnoi.State == ConnectionState.Closed)
                {
                    sqlketnoi.Open();
                    MessageBox.Show("Ket noi thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //string cmdAdd = "INSERT INTO dbo.MonHoc VALUES (1,'Lap Trinh')";
            ////string cmdAdd = "insert into dbo.MonHoc values (" +mamh +",'"+txtTenMH.Text+"');";
            //SqlCommand sqlcmd = new SqlCommand(cmdAdd, sqlketnoi);
            //sqlcmd.ExecuteNonQuery();
            string cmd = "INSERT INTO dbo.MonHoc VALUES (4,'Nguyen Nguyen')";
            SqlCommand sqlcmd = new SqlCommand(cmd, sqlketnoi);
            sqlcmd.ExecuteNonQuery();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string cmddelete = "delete from dbo.MonHoc where MaMH=4;";
            SqlCommand sqlcmd = new SqlCommand(cmddelete, sqlketnoi);
            sqlcmd.ExecuteNonQuery();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string cmdAdd = "update dbo.HocSinh set Name='Cau Truc Du Lieu Va Giai Thuat' where ID=1;";
            SqlCommand sqlcmd = new SqlCommand(cmdAdd, sqlketnoi);
            sqlcmd.ExecuteNonQuery();
        }
    }
}
