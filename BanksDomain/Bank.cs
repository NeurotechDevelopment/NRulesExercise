namespace BanksDomainModel
{
    public class Bank
    {
	    public string Name { get; set; }

		public string Country { get; set; }

		public string Remarks { get; set; }

		public decimal DepositInterest { get; set; }

		public bool? IsForeign { get; private set; }

		public bool IsForeignChecked { get; private set; }

	    public void SetForeign(bool isForeign)
	    {
		    IsForeignChecked = true;
		    IsForeign = isForeign;
	    }
    }
}
