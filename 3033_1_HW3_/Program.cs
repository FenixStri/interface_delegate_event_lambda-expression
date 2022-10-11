// Fenix Strickland 113437176
// HW 3
using _3033_1_HW3_;
using _3033_1_HW3_.Data;

using DBCon _db = new DBCon();

string userChoiceStr;

do
{
    Console.WriteLine("\nOption Menu");
    Console.WriteLine("1.Add a new receipts");
    Console.WriteLine("2.Show all receipts");
    Console.WriteLine("3.Show receipt based on a receipt ID");
    Console.WriteLine("4.Edit a receipt based on a receipt ID");
    Console.WriteLine("5.Delete a receipt based on a receipt ID");
    Console.WriteLine("6.Show the receipt with the highest total");
    Console.WriteLine("7.Show the average total of all receipts");
    Console.WriteLine("Press other keys to exit...");

    Console.Write("\nInput your option: ");
    userChoiceStr = Console.ReadLine();

    if (userChoiceStr == "1")
    {
        Console.WriteLine("Add a new receipt:");
        Console.Write("Receipt ID:");
        string id = Console.ReadLine();
        Console.Write("N Cogs: ");
        string cogsStr = Console.ReadLine();
        int cogs = Convert.ToInt32(cogsStr);

        Console.Write("N Gears: ");
        string gearsStr = Console.ReadLine();
        int gears = Convert.ToInt32(gearsStr);

        Receipt rep = new Receipt() { ReceiptID = id, CogQuantity = cogs, GearQuantity = gears };
        rep.CalculateTotal();

        _db.receipts.Add(rep);
        _db.SaveChanges();

        Console.WriteLine("New receipt added!");
        Console.WriteLine(rep);
    }
    else if (userChoiceStr == "2")
    {
        Console.WriteLine("\nAll receipts: ");
        var rList = _db.receipts.ToList();
        for (int i = 0; i< rList.Count; i++) 
        {
            Console.WriteLine(rList[i]);
        }
    }

    else if (userChoiceStr == "3")
    {
        Console.WriteLine("\nShow receipt based on a receipt ID");
        Console.Write("Receipt ID: ");
        string id = Console.ReadLine();

       var result = _db.receipts.Where(r => r.ReceiptID == id).FirstOrDefault(); //null
        if(result != null)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine($"NO such receipt with ID {id}");
        }
    }

    else if (userChoiceStr == "4")
    {
        Console.WriteLine("\nShow receipt based on a receipt ID");
        Console.Write("Receipt ID: ");
        string id = Console.ReadLine();

        var result = _db.receipts.Where(r => r.ReceiptID == id).FirstOrDefault(); //null
        if (result != null)
        {
            Console.Write("N Cogs: ");
            string cogsStr = Console.ReadLine();
            int cogs = Convert.ToInt32(cogsStr);

            Console.Write("N Gears: ");
            string gearsStr = Console.ReadLine();
            int gears = Convert.ToInt32(gearsStr);

            result.CogQuantity = cogs;
            result.GearQuantity = gears;

            result.CalculateTotal();

            _db.SaveChanges();

            Console.WriteLine("Receipt updated!!! \nNew receipt is: ");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine($"NO such receipt with ID {id}");
        }
    }

    else if (userChoiceStr == "5")
    {
        Console.WriteLine("\nDelete a receipt based on a receipt ID");
        Console.Write("Receipt ID: ");
        string id = Console.ReadLine();

        var result = _db.receipts.Where(r => r.ReceiptID == id).FirstOrDefault(); //null
        if (result != null)
        {
            _db.Remove(result);
            _db.SaveChanges();

            Console.WriteLine("Receipt deleted!");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine($"NO such receipt with ID {id}");
        }
    }

    else if (userChoiceStr == "6")
    {
        Console.WriteLine("\nShow receipt with the highest total");

        var rList = _db.receipts.ToList();
        if(rList.Count > 0)
        {
            var result = rList.MaxBy(r => r.Total);
                Console.WriteLine(result);
            

        }
        else
        {
            Console.WriteLine("No receipts in the database!!!");
        }

        
        
    }
    else if (userChoiceStr == "7")
    {
        Console.WriteLine("\nShow the average total of all receipts");

        var rList = _db.receipts.ToList();
        if (rList.Count > 0)
        {
            var result = rList.Average(r => r.Total);
            Console.WriteLine($"Total average is: {result:C2}");


        }
        else
        {
            Console.WriteLine("No receipts in the database!!!");
        }



    }

}
while(userChoiceStr == "1"|| userChoiceStr == "2" || userChoiceStr == "3" || userChoiceStr == "4" || userChoiceStr == "5" || userChoiceStr == "6" || userChoiceStr == "7");




Console.ReadLine();