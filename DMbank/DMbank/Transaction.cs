using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMbank
{
    public class Transaction
    {
        private int transactionID;
        private DateTime transactionDateTime;
        private User[] blockchain;
        private float amount;
        private User transactionUser;
        private TransactionType transactionType;
        private int partyTransaction;
        private DateTime CreatedOn;
        private int CreatedBy;
        private DateTime ModifiedOn;
        private int ModifiedBy;

        enum TransactionType
        {
            Debit,
            Credit
        }
    }
}
