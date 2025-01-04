namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {
        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            FullName = fullname;
            HoursWorked = hoursWorked;
        }
        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary; 
        }

    }
}