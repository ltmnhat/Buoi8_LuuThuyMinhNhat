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

namespace BaiTapMau
{
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=A209PC02;Initial Catalog=QL_IDNAME; Integrated Security=True";
        SqlConnection sqlcon = null;
        public Form1()
        {
            InitializeComponent();
            try
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(strcon);
                }
                if(sqlcon.State==ConnectionState.Closed)
                {
                    sqlcon.Open();
                    MessageBox.Show("Ket noi thanh cong");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO dbo.HocSinh VALUES (4,'Nguyen Nguyen')";
            SqlCommand sqlcmd = new SqlCommand(cmd, sqlcon);
            sqlcmd.ExecuteNonQuery();
        }

        private void BtnR_Click(object sender, EventArgs e)
        {

        }

        private void btnU_Click(object sender, EventArgs e)
        {
            string cmdupdate = "update dbo.HocSinh set Name='Luu Luu' where ID=3;";
            SqlCommand sqlcmd = new SqlCommand(cmdupdate, sqlcon);
            sqlcmd.ExecuteNonQuery();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            string cmddelete = "delete from dbo.HocSinh where ID=4;";
            SqlCommand sqlcmd = new SqlCommand(cmddelete, sqlcon);
            sqlcmd.ExecuteNonQuery();
        }
    }
}
