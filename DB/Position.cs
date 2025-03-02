﻿using System;
using System.Collections.Generic;

namespace WPFPersonelTracking.DB
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string PositionName { get; set; } = null!;
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
