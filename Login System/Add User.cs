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
    public partial class frm_Add_User : Form
    {
        public frm_Add_User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_UserName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_Add_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblLog' table. You can move, or remove it, as needed.
            this.tblLogTableAdapter.Fill(this.appData.tblLog);
            Edit(false);
        }
        private void Edit(bool value)
        {
            txt_UserName.Enabled = value;
            txt_Password.Enabled = value;
            Cb_Role.Enabled = value;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.tblLog.AddtblLogRow(appData.tblLog.NewtblLogRow());
                txt_UserName.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tblLog.RejectChanges();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblLogBindingSource.EndEdit();
                tblLogTableAdapter.Update(appData.tblLog);
                dvg_User.Refresh();
                txt_UserName.Focus();
                MessageBox.Show("ຂໍ້ມູນຂອງທ່ານບັນທຶກສຳເລັດແລ້ວ","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tblLog.RejectChanges();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານແນ່ໃຈທີ່ຈະລຶບບໍ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            {
                tblLogBindingSource.RemoveCurrent();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tblLogBindingSource.ResetBindings(false);
        }
    }
}
