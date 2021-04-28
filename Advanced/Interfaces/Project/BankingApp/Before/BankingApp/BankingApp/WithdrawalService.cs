using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class WithdrawalService
    {
        private AuthenticationServices _authenticateService;
        private BalanceCheckerService _balanceCheckerService;

        public WithdrawalService()
        {
            _authenticateService = new AuthenticationServices();
            _balanceCheckerService = new BalanceCheckerService();
        }

        public bool IsEligibleToWithdraw(string userName, string password, int accNum, int amount)
        {
            bool isAuthenticated = _authenticateService.Authenticate(userName, password);
            
            if(!isAuthenticated)
            {
                Console.WriteLine("The user is not valid");

            }

            return _balanceCheckerService.IsBalanceAvailable(accNum, amount);
        }
    }
}
