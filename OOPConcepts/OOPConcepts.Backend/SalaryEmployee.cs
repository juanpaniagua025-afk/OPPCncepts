namespace OOPConcepts.Backend;

public class SalaryEmployee : Employee
{
	// Fields 
	private decimal _salary;

	// Constructor corregido
	public SalaryEmployee(int id, string firstName, string lastname, bool isActive,
		Date borndate, Date hireDate, decimal salary)
		: base(id, firstName, lastname, isActive, borndate, hireDate)
	{
		Salary = salary;
	}

	// Properties
	public decimal Salary
	{
		get => _salary;
		set => _salary = ValidateSalary(value);
	}

	// Methods 
	public override decimal GetValueTopay() => Salary;

	public override string ToString() => base.ToString();

	private decimal ValidateSalary(decimal salary)
	{
		if (salary < 2000000)
		{
			throw new ArgumentOutOfRangeException(nameof(salary),
				"Salary must be greater than or equal to $2,000,000.");
		}
		return salary;
	}
}