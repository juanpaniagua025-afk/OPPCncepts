namespace OOPConcepts.Backend;

public class ComisionEmployee : Employee
{
	// Fields 
	private float _comisionpercent;
	private decimal _sales;

	// Constructor
	public ComisionEmployee(int id, string firstnmae, string lastname, bool isActive,
		Date borndate, Date hireDate, float comisionpercent, decimal sales)
		: base(id, firstnmae, lastname, isActive, borndate, hireDate)
	{
		Comisionpercent = comisionpercent;
		Sales = sales;
	}

	// Properties
	public float Comisionpercent
	{
		get => _comisionpercent;
		set => _comisionpercent = ValidatecommisionPercent(value);
	}

	public decimal Sales
	{
		get => _sales;
		set => _sales = ValidateSales(value);
	}

	// Methods
	public override decimal GetValueTopay() => (decimal)Comisionpercent * Sales;

	public override string ToString() => base.ToString() + $"\n\t" +
		$"Commision Percent: {Comisionpercent,20:P2}\n\t" +
		$"Sales............: {Sales,20:C2}";

	private float ValidatecommisionPercent(float commisionpercent)
	{
		if (commisionpercent < 0 || commisionpercent > 1)
		{
			throw new ArgumentOutOfRangeException(nameof(commisionpercent), "commision percent must be between 0 and 1.");
		}
		return commisionpercent;
	}
    private decimal ValidateSales(decimal sales)
	{
		if (sales < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(sales), "sales must be greater than or equal to 0.");
		}
		return sales;
	}   
}