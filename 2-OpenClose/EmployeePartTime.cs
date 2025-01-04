namespace OpenClose
{
    public class EmployeePartTime : IEmployee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }

        public EmployeePartTime(string fullname, int hoursWorked)
        {
            FullName = fullname;
            HoursWorked = hoursWorked;
        }
        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }

    }
}