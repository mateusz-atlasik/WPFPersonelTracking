﻿using System;
using System.Collections.Generic;

namespace WPFPersonelTracking.DB
{
    public partial class Task
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public byte[] TaskTitle { get; set; } = null!;
        public string? TaskContent { get; set; }
        public DateTime? TaskStartDate { get; set; }
        public DateTime? TaskDeliveryDate { get; set; }
        public int TaskState { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Taskstate TaskStateNavigation { get; set; } = null!;
    }
}
