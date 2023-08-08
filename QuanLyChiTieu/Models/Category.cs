using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyChiTieu.Models
{
    public partial class Category
    {
        public Category()
        {
            Incomes = new HashSet<Income>();
            Outcomes = new HashSet<Outcome>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<Outcome> Outcomes { get; set; }
    }
}
