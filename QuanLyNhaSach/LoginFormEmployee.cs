using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyNhaSach
{
    public partial class LoginFormEmployee : KryptonForm
    {
        public LoginFormEmployee()
        {
            InitializeComponent();
        }

     
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-62H0EBDL;Database=db_NhaSach; Integrated Security = true;";
            SqlConnection connection = new SqlConnection(connectionString);

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống");
            }

            else
            {
                try
                {
                    // Mở kết nối đến cơ sở dữ liệu
                    connection.Open();

                    // Lấy thông tin đăng nhập từ các trường nhập liệu
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    // Thực hiện truy vấn đến cơ sở dữ liệu để kiểm tra đăng nhập
                    string query = "SELECT * FROM NhanVien WHERE username=@username AND password=@password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Đăng nhập thành công, ẩn form đăng nhập và hiển thị form chính
                        this.Hide();
                        LandingPage nhanVienForm = new LandingPage();
                        nhanVienForm.Show();
                    }
                    else
                    {
                        // Hiển thị thông báo lỗi đăng nhập
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.");
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không mở duoc CSDL");
                    // Xử lý ngoại lệ
                }
                finally
                {
                    // Đảm bảo đóng kết nối sau khi sử dụng xong
                    connection.Close();
                }
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
