using System;
using System.Collections.Generic;

namespace WPFPersonelTracking.DB
{
    public partial class Salarymonth
    {
        public Salarymonth()
        {
            Salaries = new HashSet<Salary>();
        }

        public int Id { get; set; }
        public string MonthName { get; set; } = null!;

        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
