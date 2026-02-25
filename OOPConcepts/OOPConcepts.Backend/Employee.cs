namespace OOPConcepts.Backend;

public abstract class Employee
{
	//Constructors
	public Employee(int id, string firstnmae, string lastname, bool isActive, Date hireDate)
	{
		Id=id;
		FirstName = firstnmae;
		LastName = lastname;
		IsActive = isActive;
		Borndate = hireDate;
		HireDate = hireDate;
	}

	// Properties 
	public int Id { get; set; }
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	public bool IsActive { get; set; }
	public Date Borndate { get; set; } = null!;
	public Date HireDate { get; set; } = null!;

	// Methods 
	public override string ToString()
	{
		return $"{Id}\t{FirstName} {LastName}\n\t" +
			   $"Value to pay: {GetValueTopay(),20:C2}";			
	}

	public abstract decimal GetValueTopay();
	private decimal Validatesalary(decimal salary)
	{
       if (salary < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(salary), "Saalary");
		}
		return salary;
	}
}
