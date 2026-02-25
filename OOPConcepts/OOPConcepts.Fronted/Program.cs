using OOPConcepts.Backend;
	 
try	
{
	var employee1 = new SalaryEmployee(1010, "Juana", "Sanchez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
	var employee2 = new SalaryEmployee(2020, "Maiker", "Ramirez", true, new Date(1970, 2, 15), new Date(2015, 12, 1), 10395876);
	Console.WriteLine(employee1);
	Console.WriteLine(employee2);
}  
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
	
