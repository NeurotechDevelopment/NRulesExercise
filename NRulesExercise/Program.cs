using System.Linq;
using DataSource;
using NRules;
using NRules.Fluent;
using NRulesBanksEngine;

namespace NRulesExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			//Load rules
			var repository = new RuleRepository();
			repository.Load(x => x.From(typeof(BankIsForeignRule), typeof(BanksIsUkrainian)));
			
			//Compile rules
			var factory = repository.Compile();
			
			//Create a working session
			var session = factory.CreateSession();
			
			//Load domain model
			var banks = BanksDatasource.GetAllBanks().ToList();

			//Insert facts into rules engine's memory
			session.InsertAll(banks);

			// Execute registered rules
			session.Fire();

			// Test rules were run
			var foreignBanks = banks.Where(b => b.IsForeign.Value);
			var ukrainianBanks = banks.Where(b => !b.IsForeign.Value);
		}
	}
}
