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

		public decimal GetBalance() {
			return _balance;
		}
		protected void SetBalance(decimal newBalance) {
			if (newBalance >= 0) {
				_balance = newBalance;
			}
		}

		public string GetAccountNumber() {
			return _accountNumber;
		}
		private void SetAccountNumber(string newAccountNumber) {
			if (newAccountNumber != "") {
				_accountNumber = newAccountNumber;
			}
		}

		// getter
		public string GetHolderName() {
			return _holderName;
		}
		// setter
		public void SetHolderName(string newHolderName) {
			if (newHolderName != "") {
				_holderName = newHolderName;
			}
		}

		public BankAccount(string inputHolderName,
			string inputAccountNumber,
			decimal initialBalance) {

			SetBalance(initialBalance);
			SetAccountNumber(inputAccountNumber);
			SetHolderName(inputHolderName);
		}
	}
}
