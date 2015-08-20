namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GsmTesting
    {
        public static void Main()
        {
            GSMTest();
            CallTest();
        }

        private static void GSMTest()
        {
            GSM[] phones = new GSM[4];

            phones[0] = new GSM("Samsung", "S6 Edge", 700, "Nikolai Kostov", new Battery("13/33335/UA8G", 200, 15, BatteryType.LiIon), new Display(5.5, 16));
            phones[1] = new GSM("LG", "G Flex", 500, "Milen Kamburov", new Battery("2244/44U6/KKLI8", 190, 19, BatteryType.LiIon), new Display(6.0, 16));
            phones[2] = new GSM("Motorola", "Nexus 6", 600, "Asen Dermenjiev", new Battery("0093/478AS/9IOF1", 240, 17, BatteryType.NiCd), new Display(6.3, 16));

            phones[3] = GSM.Iphone4S;

            Console.WriteLine("-------------------------------------------------------");
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------");
            }
        }

        private static void CallTest()
        {
            GSM testGSM = new GSM("Nokia", "Lumia", 400, "Nikoi", new Battery("0093/478AS/9IOF1", 240, 17, BatteryType.NiCd), new Display(6.3, 16));

            testGSM.AddCall("12.04.2014", "14:33:58", "0883456629", 100);
            testGSM.AddCall("12.04.2014", "20:22:00", "0883454629", 300);
            testGSM.AddCall("12.05.2014", "10:12:45", "0889834231", 540);
            testGSM.AddCall("01.01.2015", "09:09:37", "0883454629", 240);
            testGSM.AddCall("12.05.2014", "11:00:03", "0889834231", 70);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(testGSM.ShowHistory());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Total call price: {0:F2}", testGSM.TotalCallPrice(0.37m));
            Console.ResetColor();

            testGSM.RemoveCall(3);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The total call price after deleting the longest call: {0:F2}", testGSM.TotalCallPrice(0.37m));
            Console.ResetColor();

            testGSM.ClearHistory();
            Console.WriteLine("Call history deleted!!!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(testGSM.ShowHistory());
            Console.ResetColor();
        }
    }
}
