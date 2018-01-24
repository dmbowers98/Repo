using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMbank
{
    class Account
    {
        private int userID;
        private int accountID;
        private float balance;
        private AccountType accountType;
        private DateTime CreatedOn;
        private int CreatedBy;
        private DateTime ModifiedOn;
        private int ModifiedBy;

        public Boolean transfer()
        {
            return true;
        }
    }

    enum AccountType
    {
        Savings,
        Checking
    }
}
