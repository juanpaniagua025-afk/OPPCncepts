using System;
using System.Collections.Generic;
using System.Text;

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
		return $"{Id}/t{FirstName} {LastName}/n/t" +
			   $"value to pay: {GetValueTopay()}";
	}

	public abstract decimal GetValueTopay();	
}
