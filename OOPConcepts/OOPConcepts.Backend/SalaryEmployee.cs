namespace OOPConcepts.Backend;

public class SalaryEmployee : Employee
{
	// Fields 
	private decimal _salary;

	// Constructors
	public SalaryEmployee(int id, string firstnmae, string lastname, bool isActive, Date hireDate, Date date, decimal salary) :
		base(id, firstnmae, lastname, isActive, hireDate)
	{
		_salary = salary;
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
			throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $2,000,000.");
		}
		return salary;
	}
}
