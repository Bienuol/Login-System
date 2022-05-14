
namespace Login_System
{
    partial class frm_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Attendence = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Attendence
            // 
            this.btn_Attendence.Font = new System.Drawing.Font("Phetsarath OT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Attendence.Location = new System.Drawing.Point(104, 119);
            this.btn_Attendence.Name = "btn_Attendence";
            this.btn_Attendence.Size = new System.Drawing.Size(142, 67);
            this.btn_Attendence.TabIndex = 0;
            this.btn_Attendence.Text = "ເຂົ້າຮ່ວມ";
            this.btn_Attendence.UseVisualStyleBackColor = true;
            // 
            // btn_Student
            // 
            this.btn_Student.Font = new System.Drawing.Font("Phetsarath OT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.Location = new System.Drawing.Point(325, 119);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(142, 67);
            this.btn_Student.TabIndex = 1;
            this.btn_Student.Text = "ນັກສຶກສາ";
            this.btn_Student.UseVisualStyleBackColor = true;
            // 
            // btn_Report
            // 
            this.btn_Report.Font = new System.Drawing.Font("Phetsarath OT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.Location = new System.Drawing.Point(529, 119);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(142, 67);
            this.btn_Report.TabIndex = 2;
            this.btn_Report.Text = "ແຈ້ງການ";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // btn_Payment
            // 
            this.btn_Payment.Font = new System.Drawing.Font("Phetsarath OT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payment.Location = new System.Drawing.Point(104, 249);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(142, 67);
            this.btn_Payment.TabIndex = 3;
            this.btn_Payment.Text = "ການຊຳລະເງີນ";
            this.btn_Payment.UseVisualStyleBackColor = true;
            // 
            // btn_User
            // 
            this.btn_User.Font = new System.Drawing.Font("Phetsarath OT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.Location = new System.Drawing.Point(325, 249);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(142, 67);
            this.btn_User.TabIndex = 4;
            this.btn_User.Text = "ເພີ່ມຜູ້ໃຊ້";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.Font = new System.Drawing.Font("Phetsarath OT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.Location = new System.Drawing.Point(529, 249);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(142, 67);
            this.btn_Setting.TabIndex = 5;
            this.btn_Setting.Text = "ຕັ້ງຄ່າ";
            this.btn_Setting.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(703, 17);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(67, 29);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.btn_User);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_Student);
            this.Controls.Add(this.btn_Attendence);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frm_Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Attendence;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Logout;
    }
}