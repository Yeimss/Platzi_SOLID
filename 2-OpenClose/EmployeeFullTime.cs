namespace OpenClose
{
    public class EmployeeFullTime : IEmployee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            FullName = fullname;
            HoursWorked = hoursWorked;
        }
        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary; 
        }

    }
}