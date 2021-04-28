using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class BalanceCheckerService
    {
        private DataAccessService _dataAccessService;

        public BalanceCheckerService()
        {
            _dataAccessService = new DataAccessService();
        }

        public bool IsBalanceAvailable(int accNumber, int amount)
        {
            return _dataAccessService.IsBalanceAvailable(accNumber, amount);
        }

    }
}
