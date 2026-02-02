using DevExpress.Xpo.Logger;
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
    public partial class SuccessMessageForm : XtraForm
    {
        public SuccessMessageForm(string message)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Không viền
            this.StartPosition = FormStartPosition.CenterScreen; // Giữa màn hình
            lblMessage.Text = message; // Gán nội dung thông báo
            this.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); // Màu nền xanh lá
            lblMessage.ForeColor = System.Drawing.Color.White; // Chữ trắng
        }

        private void SuccessMessageForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer { Interval = 2000 }; // 2 giây
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                this.Close(); // Đóng form
            };
            timer.Start();
        }
    }
}