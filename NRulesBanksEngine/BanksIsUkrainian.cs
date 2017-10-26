using BanksDomainModel;
using NRules.Fluent.Dsl;

namespace NRulesBanksEngine
{
	public class BanksIsUkrainian : Rule
	{
		public override void Define()
		{
			Bank bank = null;

			When()
				.Match<Bank>(() => bank)
				//.Match<Bank>(_=> !bank.IsForeignChecked)
				.Match<Bank>(_=> bank.Country == "Ukraine");

			Then()
				.Do(ctx => bank.SetForeign(false))
				.Do(ctx => ctx.Retract(bank));
			//.Do(ctx => ctx.Update(bank));
		}
	}
}
