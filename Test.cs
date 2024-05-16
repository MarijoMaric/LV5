using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5_Maric
{
    public class Test
    {

        public static void Z1()
        {
            IShipable first = new Product("Prvi", 5, 2.5);
            IShipable seconde = new Product("Drugi", 10, 5);
            IShipable third = new Product("Treci", 15, 7.5);
            Box box = new Box("Moj box");

            box.Add(first);
            box.Add(seconde);
            box.Add(third);

            Console.WriteLine(box.Description()); 
            Console.WriteLine($"Price: {box.Price}");
            Console.WriteLine($"Weight: {box.Weight}");

            Console.WriteLine();

            Console.WriteLine("First product: ");
            Console.WriteLine(first.Description());
            Console.WriteLine($"Price: {first.Price}");
            Console.WriteLine($"Weight: {first.Weight}");
        }

        public static void Z2()
        {
            ShippingService shippingService = new ShippingService(5);

            IShipable first = new Product("Prvi", 5, 2.5);
            IShipable seconde = new Product("Drugi", 10, 5);
            IShipable third = new Product("Treci", 15, 7.5);
            Box box = new Box("Moj box");

            box.Add(first);
            box.Add(seconde);
            box.Add(third);

            Console.WriteLine($"Box shipping price: {shippingService.CalculateShippingPrice(box)}");
            Console.WriteLine($"Product shipping price: {shippingService.CalculateShippingPrice(first)}");
        }

        public static void Z3()
        {
            DataConsolePrinter myPrinter = new DataConsolePrinter();
            IDataset dataset = new Dataset("C:\\Users\\ricma\\Desktop\\RPPOON - labosi\\lv5_Maric\\data.csv");

            myPrinter.Print(dataset);

            User firstUser = User.GenerateUser("First one");
            User SecondeUser = User.GenerateUser("Seconde one");

            IDataset data = new VirtualProxyDataset("C:\\Users\\ricma\\Desktop\\RPPOON - labosi\\lv5_Maric\\data.csv");
            dataset = new ProtectionProxyDataset(firstUser);
            myPrinter.Print(dataset);

            dataset = new ProtectionProxyDataset(SecondeUser);
            myPrinter.Print(dataset);


        }

        public static void Z4()
        {
            DataConsolePrinter consolePrinter = new DataConsolePrinter();
            LoggingProxyData proxy = new LoggingProxyData(@"C:\Users\Ricma\Desktop\RPPOON - labosi\lv5_Maric\txt.txt");

            consolePrinter.Print(proxy);
            proxy.LogMessage("Message: ");
        }

        public static void Z5()
        {
            ITheme theme = new DarkTheme();
            ReminderNote note = new ReminderNote("New theme is here", theme);
            note.Show();

            Console.WriteLine();
            theme = new LightTheme();
            note.Theme = theme;
            note.Show();

        }

        public static void Z6()
        {
            GroupNote firstNote = new GroupNote("First Group", new DarkTheme());
            firstNote.AddName("First one");
            firstNote.AddName("Seconde one");

            GroupNote secondeNote = new GroupNote("Seconde Group", new LightTheme());
            secondeNote.AddName("Fist one");
            secondeNote.AddName("Seconde one");
            

            firstNote.Show();
            Console.WriteLine();
            secondeNote.Show();


        }
    }
}
