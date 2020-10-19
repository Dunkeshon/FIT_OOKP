using System;
using System.Collections.Generic;
using System.Text;

namespace eazyLab1
{
    class Statement
    {
        public int WarehouseId { get; }
        public float BalanceAtStart { get; }
        public float Received { get; } // add to balance 
        public float Issued { get; } // distract from balance 
        public float BalanceInTheEnd { get; }

        public Statement(int warehouseId, float balanceAtStart, float received, float issued)
        {
            WarehouseId = warehouseId;
            BalanceAtStart = balanceAtStart;
            Received = received;
            Issued = issued;
            BalanceInTheEnd = BalanceAtStart + Received - Issued;
        }

    }
}
