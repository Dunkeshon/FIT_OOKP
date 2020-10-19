using System;
using System.Collections;
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
            return "Warehouse Id: " +  WarehouseId + " | " 
                + "Balance at start of the period: " + BalanceAtStart + " grn" + " | " 
                + "Received: " + Received + " grn" + " | " 
                + "Issued: " + Issued + " grn" + " | " 
                + "Balance in the end of the period: " + BalanceInTheEnd + " grn";
        }
        public string ToStringUsingBackslash()
        {
            return WarehouseId + "\\" + BalanceAtStart + "\\" + Received + "\\" + Issued + "\\" + BalanceInTheEnd;
        }
        private float CalculateBalanceInTheEnd()
        {
            return BalanceAtStart + Received - Issued;
        }
        public static ArrayList GetArrayListOfStatementsFromFile(string fileName)
        {
            ArrayList arrayList = new ArrayList();
            string infoFromFile = WorkWithFiles.ReadEverythingFromFile(fileName);
            string[] lines = infoFromFile.Split('\n');
            foreach(string i in lines)
            {
                if (i != "")
                {
                string[] atoms = i.Split("\\");
                Statement temp = new Statement(Int32.Parse(atoms[0]), float.Parse(atoms[1]), float.Parse(atoms[2]), float.Parse(atoms[3]));
                arrayList.Add(temp);
                }
            }
            return arrayList;
        }
        public static Statement CreateAndFillFromConsole()
        {
            Console.WriteLine("-----------------------");
            Console.Write("Enter Warehouse Id: ");
            int id = Int32.Parse(Console.ReadLine());
            Console.Write("Enter balance at the start of period: ");
            float balanceAtStart = float.Parse(Console.ReadLine());
            Console.Write("Enter received money : ");
            float received = float.Parse(Console.ReadLine());
            Console.Write("Enter issued money: ");
            float issued = float.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            return new Statement(id, balanceAtStart, received, issued);
        }
        public static float SumOfBalanceAtStart(ArrayList list)
        {
            float sum = 0;
            foreach(Statement i in list)
            {
                sum += i.BalanceAtStart;
            }
            return sum;
        }
        public static float SumOfReceived(ArrayList list)
        {
            float sum = 0;
            foreach (Statement i in list)
            {
                sum += i.Received;
            }
            return sum;
        }
        public static float SumOfIssued(ArrayList list)
        {
            float sum = 0;
            foreach (Statement i in list)
            {
                sum += i.Issued;
            }
            return sum;
        }
        public static float SumOfBalanceInTheEnd(ArrayList list)
        {
            float sum = 0;
            foreach (Statement i in list)
            {
                sum += i.BalanceInTheEnd;
            }
            return sum;
        }


    }
}
