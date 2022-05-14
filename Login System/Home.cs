using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class frm_Home : Form
    {
        public object Lbl_logUser { get; private set; }

        public frm_Home(string log)
        {
            InitializeComponent();
            Lbl_logUser = log;
        }

        private void btn_Loguser_Click(object sender, EventArgs e)
        {

        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            frm_Add_User fau = new frm_Add_User();
            fau.ShowDialog();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_login fl = new frm_login();
            fl.Show();
            this.Hide();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            if (ulog.type == "A")
            {
                btn_User.Visible = true;
                btn_Attendence.Visible = true;
                btn_Payment.Visible = true;
                btn_Report.Visible = true;
                btn_Setting.Visible = true;
                btn_Student.Visible = true;

            }
            else if (ulog.type == "U")
            {

                btn_User.Visible = false;
                btn_Attendence.Visible = false;
                btn_Payment.Visible = false;
                btn_Report.Visible = false;
                btn_Setting.Visible = false;
                btn_Student.Visible = false;
            }
        }
    }
}
