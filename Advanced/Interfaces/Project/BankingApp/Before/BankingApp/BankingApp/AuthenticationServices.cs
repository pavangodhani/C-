using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class AuthenticationServices
    {
        private DataAccessService _dataAccessService;

        public AuthenticationServices()
        {
            _dataAccessService = new DataAccessService();
        }

        public bool Authenticate(string userName, string password)
        {
            return _dataAccessService.IsUserValid(userName, password);
        }
    }
}
