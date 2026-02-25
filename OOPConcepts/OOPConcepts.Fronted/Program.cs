using OOPConcepts.Backend;
	 
try	
{
	var employees = new List<Employee>();
	decimal payroll = 0;
	var employee1 = new SalaryEmployee(1010, "Juana", "Sanchez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
	employees.Add(employee1);
	var employee2 = new SalaryEmployee(2020, "Maiker", "Ramirez", true, new Date(1970, 2, 15), new Date(2015, 12, 1), 10395876);
	employees.Add(employee2);
	var employee3 = new HourlyEmployee(3030, "Ana", "lopez", true, new Date(1995, 8, 20), new Date(2022, 6, 1), 17000, 95);
	employees.Add(employee3);
	var employee4 = new HourlyEmployee(4040, "Juanma", "Perez", true, new Date(1998, 2, 20), new Date(2021, 6, 1), 10000, 112);
	employees.Add(employee4);
	var employee5 = new ComisionEmployee(5050, "Nubia", "Uribe", true, new Date(1979, 11, 10), new Date(2018, 3, 15), 0.03f, 500000000);
	employees.Add(employee5);
	var employee6 = new ComisionEmployee(5050, "Diego", "Martinez", true, new Date(1995, 8, 30), new Date(2018, 9, 1), 0.03f, 110000000);
	employees.Add(employee6);
	var employee7 = new BaseComisionEmployee(7070, "Sofia", "Garcia", true, new Date(1993,11, 25), new Date(2019, 5, 28), 0.015f, 250000000, 550000);
	employees.Add(employee7);
	var employee8 = new BaseComisionEmployee(8080, "Stiven", "Rodriguez", true, new Date(1988, 4, 10), new Date(2015, 2, 1), 0.015f, 0, 550000);
	employees.Add(employee8);

	foreach (var employee in employees)
	{
		Console.WriteLine(new string('-', 47));
		Console.WriteLine(employee);
		payroll += employee.GetValueTopay();
	}
	Console.WriteLine(new string('=', 47));
	Console.WriteLine($"Payroll..................: {payroll,20:C2}");
}  
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
	
