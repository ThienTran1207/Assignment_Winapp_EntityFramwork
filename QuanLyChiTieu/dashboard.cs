using QuanLyChiTieu.Models;
using User = QuanLyChiTieu.Models.User;

namespace QuanLyChiTieu
{
    public partial class dashboard : Form
    {

        User curUser = new User();
        public dashboard(User user)
        {
            InitializeComponent();

            curUser = user;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            using (var db = new quan_ly_chi_tieuContext())
            {
                var thu = db.Incomes.Sum(x => x.Money).ToString();
                var chi = db.Outcomes.Sum(x => x.Money).ToString();
                double du = double.Parse(thu) - double.Parse(chi);
                txtThu.Text = thu;
                txtChi.Text = chi;
                txtDu.Text = du.ToString();
            }
        }

        private void dashlbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashboard = new dashboard(curUser);
            dashboard.Show();
        }

        private void icomelbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            income income = new income(curUser);
            income.Show();
        }

        private void outcomelbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            outcome outcome = new outcome(curUser);
            outcome.Show();
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
