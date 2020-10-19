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
        public float BalanceInTheEnd { get; private set; } // calculate in constructor

        public Statement(int warehouseId, float balanceAtStart, float received, float issued)
        {
            WarehouseId = warehouseId;
            BalanceAtStart = balanceAtStart;
            Received = received;
            Issued = issued;
            BalanceInTheEnd = CalculateBalanceInTheEnd();
        }
        public override string ToString()
        {
            return "WarehouseId: " +  WarehouseId + " | " 
                + "Balance at start of the period: " + BalanceAtStart + " grn" + " | " 
                + "Received: " + Received + " grn" + " | " 
                + "Issued: " + Issued + " grn" + " | " 
                + "BalanceInTheEnd: "+ BalanceInTheEnd + " grn";
        }
        public string ToStringUsingBackslash()
        {
            return WarehouseId + "\\" + BalanceAtStart + "\\" + Received + "\\" + Issued + "\\" + BalanceInTheEnd;
        }
        private float CalculateBalanceInTheEnd()
        {
            return BalanceAtStart + Received - Issued;
        }

    }
}
