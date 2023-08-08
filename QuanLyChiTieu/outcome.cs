using Microsoft.EntityFrameworkCore;
using QuanLyChiTieu.Models;

namespace QuanLyChiTieu
{
    public partial class outcome : Form
    {

        User curUser = new User();
        public outcome(User user)
        {
            InitializeComponent();
            curUser = user;
        }
        private void outcome_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using (var db = new quan_ly_chi_tieuContext())
            {
                dataGridView1.DataSource = db.Outcomes.Include("Category").Where(x => x.Uid == curUser.Id).Select(x => new
                {
                    x.Id,
                    x.Category.Name,
                    x.Money,
                    x.DateUse,
                    x.Description,
                }).ToList();
                cbcategory.DataSource = db.Categories.Select(x => x.Name).ToList();
                txbTongChi.Text = Convert.ToString(db.Outcomes.Sum(x => x.Money));
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

        private void Edit_Click(object sender, EventArgs e)
        {
            using (var db = new quan_ly_chi_tieuContext())
            {
                Outcome outcome = (Outcome)db.Outcomes.Where(x => x.Id == int.Parse(txtid.Text)).FirstOrDefault();
                Category category = db.Categories.Where(x => x.Name == cbcategory.Text).FirstOrDefault();
                try
                {
                    outcome.CategoryId = category.Id;
                    outcome.Money = double.Parse(txtmoney.Text);
                    outcome.DateUse = DateTime.Parse(dateUse.Value.ToString("yyyy/MM/dd"));
                    outcome.Description = txtdesc.Text;
                    outcome.Uid = curUser.Id;
                    db.Update(outcome);
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Edit success!");
                    }
                    else
                    {
                        MessageBox.Show("Edit fail!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Money must be a number");
                }
            }
            loadData();

        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (var db = new quan_ly_chi_tieuContext())
            {
                Outcome outcome = new Outcome();
                Category category = db.Categories.Where(x => x.Name == cbcategory.Text).FirstOrDefault();
                try
                {
                    outcome.CategoryId = category.Id;
                    outcome.Money = double.Parse(txtmoney.Text);
                    outcome.DateUse = DateTime.Parse(dateUse.Value.ToString("yyyy/MM/dd"));
                    outcome.Description = txtdesc.Text;
                    outcome.Uid = curUser.Id;
                    db.Add(outcome);
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Add success!");
                    }
                    else
                    {
                        MessageBox.Show("Add fail!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Money must be a number");
                }
            }
            loadData();
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            using (var db = new quan_ly_chi_tieuContext())
            {
                Outcome outcome = (Outcome)db.Outcomes.Where(x => x.Id == int.Parse(txtid.Text)).FirstOrDefault();
                db.Remove(outcome);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Delete success!");
                }
                else
                {
                    MessageBox.Show("Delete fail!");
                }
            }
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            cbcategory.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txtmoney.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            dateUse.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            txtdesc.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void outcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
