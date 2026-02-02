using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHANSU
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly QLNHANSUEntities db ;
        private readonly UserDTO userDTO;
        public frmLogin()
        {
            InitializeComponent();
            db = new QLNHANSUEntities();
            userDTO = new UserDTO();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            var user = userDTO.Login(txt_UserName.Text, txt_Password.Text);
            if (user != null)
            {
                Session.CurrentUser = user;

                SuccessMessageForm successForm = new SuccessMessageForm("Đăng nhập thành công!");
                successForm.Show();

                Timer timer = new Timer { Interval = 2000 };
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    successForm.Close();
                    this.Hide();
                    MainForm main = new MainForm();
                    main.ShowDialog();
                };
                timer.Start();
            }
            else
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Submit.PerformClick(); // Kích hoạt sự kiện Click của btn_Submit
                e.Handled = true; // Ngăn âm thanh "ding" khi nhấn Enter
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Submit.PerformClick(); // Kích hoạt sự kiện Click của btn_Submit
                e.Handled = true; // Ngăn âm thanh "ding" khi nhấn Enter
            }
        }
    }
}