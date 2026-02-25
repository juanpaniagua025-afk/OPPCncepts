namespace OOPConcepts.Backend;

public class BaseComisionEmployee : ComisionEmployee
{
	// Fields
	private decimal _salary;

	// Constructor
	public BaseComisionEmployee(int id, string firstName, string lastName, bool isActive,
		Date bornDate, Date hireDate, float comisionpercent, decimal sales, decimal salary)
		: base(id, firstName, lastName, isActive, bornDate, hireDate, comisionpercent, sales)
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
	public override decimal GetValueTopay() => base.GetValueTopay() + Salary;

	public override string ToString() => $"{base.ToString()}" +
		$"\n\tsalary base......: {Salary,20:C2}";

	private decimal ValidateSalary(decimal salary)
	{
		if (salary < 500000)
		{
			throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $500,000");
		}
		return salary;
	}
}