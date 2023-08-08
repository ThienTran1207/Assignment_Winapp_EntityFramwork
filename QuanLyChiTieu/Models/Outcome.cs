using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyChiTieu.Models
{
    public partial class Outcome
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public double? Money { get; set; }
        public DateTime? DateUse { get; set; }
        public string Description { get; set; }
        public int? Uid { get; set; }

        public virtual Category Category { get; set; }
        public virtual User UidNavigation { get; set; }
    }
}
