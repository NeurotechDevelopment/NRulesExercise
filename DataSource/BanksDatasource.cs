using BanksDomainModel;
using System.Collections.Generic;

namespace DataSource
{
    public class BanksDatasource
    {
	    public static IEnumerable<Bank> GetAllBanks()
	    {
		    yield return new Bank
		    {
			    Name = "ОЩАДБАНК",
			    Country = "Ukraine",
			    DepositInterest = 13.5m,
			    Remarks = ""
		    };

			yield return new Bank
			{
				Name = "Укрэксимбанк",
				Country = "Ukraine",
				DepositInterest = 12.5m,
				Remarks = ""
			};

			yield return new Bank
			{
				Name = "СБЕРБАНК РФ",
				Country = "Russia",
				DepositInterest = 16m,
				Remarks = "Будет выкупаться Украиной. Не дает кредитов 2 года"
			};

			yield return new Bank
			{
				Name = "Кредобанк",
				Country = "Poland",
				DepositInterest = 13.0m,
				Remarks = ""
			};

			yield return new Bank
			{
				Name = "ProCrediBank",
				Country = "Germany",
				DepositInterest = 14.0m,
				Remarks = ""
			};

			yield return new Bank
			{
				Name = "Укргазбанк",
				Country = "Ukraine",
				DepositInterest = 13.5m,
				Remarks = ""
			};

			yield return new Bank
			{
				Name = "Альфа-Банк",
				Country = "Luxemburg",
				DepositInterest = 14.0m,
				Remarks = ""
			};

			yield return new Bank
			{
				Name = "Укрсоцбанк",
				Country = "Luxemburg",
				DepositInterest = 14.0m,
				Remarks = ""
			};

			yield return new Bank
			{
				Name = "ОТП Банк",
				Country = "Hungary",
				DepositInterest = 12.5m,
				Remarks = ""
			};

			yield return new Bank
			{
				Name = "ПУМБ",
				Country = "Ukraine",
				DepositInterest = 13.1m,
				Remarks = ""
			};
		}
    }
}
