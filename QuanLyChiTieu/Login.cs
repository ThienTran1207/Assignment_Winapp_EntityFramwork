using QuanLyChiTieu.Models;
using User = QuanLyChiTieu.Models.User;

namespace QuanLyChiTieu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new quan_ly_chi_tieuContext())
            {
                string check = "fail";
                List<User> users = db.Users.ToList();
                User u = new User();
                foreach (var user in users)
                {
                    if (txbUser.Text.Equals(user.Name) && txbPass.Text.Equals(user.Password))
                    {
                        u = user;
                        check = "ok";
                    }
                }
                if (check == "ok")
                {
                    this.Hide();
                    dashboard dashboard = new dashboard(u);
                    dashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
