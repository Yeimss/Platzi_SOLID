namespace OpenClose
{
	public abstract class Employee
	{
                public string FullName { get; set; }
                public int HoursWorked { get; set; }

                public abstract decimal CalculateSalaryMonthly();
	}
}

