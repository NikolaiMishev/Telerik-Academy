using System;

class Garden
{
    static void Main()
    {
        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());

        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());

        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());

        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());

        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());

        int beanSeeds = int.Parse(Console.ReadLine());

        double tomatoSeedCost = 0.5;
        double cucumberSeedCost = 0.4;
        double potatoSeedCost = 0.25;
        double carrotSeedCost = 0.6;
        double cabbageSeedCost = 0.3;
        double beanSeedCost = 0.4;

        int gardenArea = 250;
        int areaWithoutBeans = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        double totalCosts = tomatoSeeds * tomatoSeedCost + cucumberSeeds * cucumberSeedCost + potatoSeeds * potatoSeedCost +
               carrotSeeds * carrotSeedCost + cabbageSeeds * cabbageSeedCost + beanSeeds * beanSeedCost;

        Console.WriteLine("Total costs: {0:F2}", totalCosts);
        if (areaWithoutBeans > gardenArea)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (areaWithoutBeans == gardenArea)
        {
            Console.WriteLine("No area for beans");
        }
        else if (areaWithoutBeans < gardenArea)
        {
            Console.WriteLine("Beans area: {0}", gardenArea-areaWithoutBeans);
        }


    }
}