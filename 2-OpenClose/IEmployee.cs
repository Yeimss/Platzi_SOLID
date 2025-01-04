public interface IEmployee
{
    string FullName { get; set; }
    int HoursWorked { get; set; }
    public decimal CalculateSalaryMonthly();
}