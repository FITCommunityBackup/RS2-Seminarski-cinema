﻿using System.Collections.Generic;

namespace Cinema.Models.Dtos.Reports
{
    public class UserMonthlySalesDto
    {
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public decimal UserYearlyTotal { get; set; }
        public IList<MonthlySaleTotalDto> UserMonthlyTotals { get; set; }
    }
}
