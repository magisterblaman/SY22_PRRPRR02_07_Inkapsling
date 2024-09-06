using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_07_Inkapsling {
	internal class BankAccount {
		private decimal _balance;
		private string _accountNumber;
		private string _holderName;

		public decimal Balance {
			get {
				return _balance;
			}
			protected set {
				if (value >= 0) {
					_balance = value;
				}
			}
		}

		public string AccountNumber {
			get {
				return _accountNumber;
			}
			private set {
				if (value != "") {
					_accountNumber = value;
				}
			}
		}

		public string HolderName {
			get {
				return _holderName;
			}
			set {
				if (value != "") {
					_holderName = value;
				}
			}
		}

		public BankAccount(string inputHolderName,
			string inputAccountNumber,
			decimal initialBalance) {

			Balance = initialBalance; // samma som SetBalance(initialBalance)
			AccountNumber = inputAccountNumber;
			HolderName = inputHolderName;
		}
	}
}
