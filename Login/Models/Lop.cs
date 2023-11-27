﻿using System;
using System.Collections.Generic;

namespace Quan_ly_Sinh_Vien.Models
{
    public partial class Lop
    {
        public Lop()
        {
            Sinhviens = new HashSet<Sinhvien>();
        }

        public string Malop { get; set; } = null!;
        public string Tenlop { get; set; } = null!;
        public int? Siso { get; set; }

        public virtual ICollection<Sinhvien> Sinhviens { get; set; }
    }
}
