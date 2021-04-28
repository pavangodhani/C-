using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class DataAccessService
    {
        public bool IsUserValid(string userName, string password)
        {
            return userName == "John";
        }

        public bool IsBalanceAvailable(int accountNumber, int amount)
        {
            return true;
        }
    }
}
