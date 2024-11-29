﻿namespace SandTetris.Entities;

public class SalaryDetail
{
    public string EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;
    public int Month { get; set; }
    public int Year { get; set; }
    public decimal BaseSalary { get; set; }

    public int DaysAbsent { get; set; }
    public int DaysOnLeave { get; set; }
    public decimal FinalSalary { get; set; }
}
