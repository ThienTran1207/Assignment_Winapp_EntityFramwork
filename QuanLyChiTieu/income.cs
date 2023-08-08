using Microsoft.EntityFrameworkCore;
using QuanLyChiTieu.Models;

namespace QuanLyChiTieu
{
    public partial class income : Form
    {

        User curUser = new User();
        public income(User user)
        {
            InitializeComponent();
            curUser = user;
        }
        private void income_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            using (var db = new quan_ly_chi_tieuContext())
            {
                dataGridView1.DataSource = db.Incomes.Include("Category").Where(x => x.Uid == curUser.Id).Select(x => new
                {
                    x.Id,
                    x.Category.Name,
                    x.Money,
                    x.DateUse,
                    x.Description,
                }).ToList();
                cbcategory.DataSource = db.Categories.Select(x => x.Name).ToList();
                txbTongThu.Text = Convert.ToString(db.Incomes.Sum(x => x.Money));
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
                Income income = (Income)db.Incomes.Where(x => x.Id == int.Parse(txtid.Text)).FirstOrDefault();
                Category category = db.Categories.Where(x => x.Name == cbcategory.Text).FirstOrDefault();
                try
                {
                    income.CategoryId = category.Id;
                    income.Money = double.Parse(txtmoney.Text);
                    income.DateUse = DateTime.Parse(dateUse.Value.ToString("yyyy/MM/dd"));
                    income.Description = txtdesc.Text;
                    income.Uid = curUser.Id;
                    db.Update(income);
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
                Income income = new Income();
                Category category = db.Categories.Where(x => x.Name == cbcategory.Text).FirstOrDefault();
                try
                {
                    income.CategoryId = category.Id;
                    income.Money = double.Parse(txtmoney.Text);
                    income.DateUse = DateTime.Parse(dateUse.Value.ToString("yyyy/MM/dd"));
                    income.Description = txtdesc.Text;
                    income.Uid = curUser.Id;
                    db.Add(income);
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
                Income income = (Income)db.Incomes.Where(x => x.Id == int.Parse(txtid.Text)).FirstOrDefault();
                db.Remove(income);
                db.SaveChanges();
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

        private void income_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int count = 3;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if(count % 2  == 0)
            {
                using (var db = new quan_ly_chi_tieuContext())
                {
                    dataGridView1.DataSource = db.Incomes.Include("Category").Where(x => x.Uid == curUser.Id).Select(x => new
                    {
                        x.Id,
                        x.Category.Name,
                        x.Money,
                        x.DateUse,
                        x.Description,
                    }).OrderByDescending(x => x.Money)
                        .ToList();
                    cbcategory.DataSource = db.Categories.Select(x => x.Name).ToList();
                    txbTongThu.Text = Convert.ToString(db.Incomes.Sum(x => x.Money));
                }
                count++;
            }
            else
            {
                using (var db = new quan_ly_chi_tieuContext())
                {
                    dataGridView1.DataSource = db.Incomes.Include("Category").Where(x => x.Uid == curUser.Id).Select(x => new
                    {
                        x.Id,
                        x.Category.Name,
                        x.Money,
                        x.DateUse,
                        x.Description,
                    }).OrderBy(x => x.Money)
                        .ToList();
                    cbcategory.DataSource = db.Categories.Select(x => x.Name).ToList();
                    txbTongThu.Text = Convert.ToString(db.Incomes.Sum(x => x.Money));
                    
                }
                count++;
            }
            */
        }

        
    }
}
