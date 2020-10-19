using System;
using System.Collections;
using System.Text;

namespace eazyLab1
{
    class Statement
    {
        // id ?
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
        public static ArrayList GetArrayListOfStatementsFromFile(string fileName)
        {
            ArrayList arrayList = new ArrayList();
            string infoFromFile = WorkWithFiles.ReadEverythingFromFile(fileName);
            string[] lines = infoFromFile.Split('\n');
            foreach(string i in lines)
            {
                string[] atoms = i.Split("\\");
                Statement temp = new Statement(Int32.Parse(atoms[0]), float.Parse(atoms[1]), float.Parse(atoms[2]), float.Parse(atoms[3]));
                arrayList.Add(temp);
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

    }
}
