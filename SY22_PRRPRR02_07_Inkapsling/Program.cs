using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_07_Inkapsling {
	internal class Program {
		static void Main(string[] args) {
			BankAccount account = new BankAccount("Hannes Blåman", "437957487485", 100);

			Console.WriteLine("Kontot för "
				 + account.GetHolderName() + " (kontonr: "
				 + account.GetAccountNumber()
				 + ") har " + account.GetBalance() + "kr");

			account.SetHolderName("Per Blåman");

			Console.WriteLine("Kontot för "
				 + account.GetHolderName() + " (kontonr: "
				 + account.GetAccountNumber()
				 + ") har " + account.GetBalance() + "kr");

			
		}
	}
}
