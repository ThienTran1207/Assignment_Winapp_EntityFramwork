using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyChiTieu.Models
{
    public partial class User
    {
        public User()
        {
            Incomes = new HashSet<Income>();
            Outcomes = new HashSet<Outcome>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool? Gender { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<Outcome> Outcomes { get; set; }
    }
}
