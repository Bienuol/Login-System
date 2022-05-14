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



namespace Login_System
{
    public partial class frm_login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.umDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public frm_login()
        {
            InitializeComponent();
        }

        string log;
        private object txt_UserName;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblLog WHERE Username ='" +txt_Usename.Text+"' and Password='" +txt_Password.Text+"'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if(i==1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[3].ToString() == "Admin")
                {
                    ulog.type = "A";
                }
                else if (dr[3].ToString() == "User")
                {
                    ulog.type = "U";
                }
                log = "Welcome:" +txt_UserName;
                this.Hide();


                frm_Home fh = new frm_Home(log);
                fh.Show();
            }
            else
            {
                MessageBox.Show("ກະລຸນາກວດສອບຊື່ຜູ້ໃຊ້ ແລະ ລະຫັດຂອງທ່ານຄືນ ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
