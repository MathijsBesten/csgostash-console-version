using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoGUI
{
    public class SkinFunction
    {
        public static void searchSkin()
        {
            int categorieCount = 0;
            int gunCount = 0;
            int wearCount = 0;
            Console.WriteLine("Welkom op de console versie van CS:GO Stash");
            Console.WriteLine("Kies een van de onderstaande categorieen");
            Console.WriteLine("");
            foreach (var categorie in PublicValues.gunCategories)
            {
                Console.WriteLine(categorieCount + ". " + PublicValues.gunCategoriesNames[categorieCount]);
                categorieCount++;
            }
            Console.WriteLine("");
            int IDchosenCategorie;
            bool tryparseChosen = int.TryParse(Console.ReadLine(), out IDchosenCategorie);
            if (IDchosenCategorie < 4)
            {
                var chosenCategorie = PublicValues.gunCategories[IDchosenCategorie];
                Console.WriteLine("");
                foreach (var gun in chosenCategorie)
                {
                    Console.WriteLine(gunCount + ". = " + gun);
                    gunCount++;
                }
                Console.WriteLine("");
                Console.WriteLine("Maak uw keuze");
                Console.WriteLine("");
                int IDchosengun;
                bool tryparseChosenGun = int.TryParse(Console.ReadLine(), out IDchosengun);
                if (IDchosengun < chosenCategorie.Count)
                {
                    var chosenGun = chosenCategorie[IDchosengun];
                    if (chosenGun.Contains(" "))
                    {
                        chosenGun = chosenGun.Replace(" ", "+");
                    }
                    PublicValues.skinURLs.Clear();
                    var allSkins = GetAllSkins.allSkins(chosenGun);
                    Console.WriteLine("");
                    Console.WriteLine("Kies uw skin");
                    int IDchosenSkin;
                    bool tryparseChosenSkin = int.TryParse(Console.ReadLine(), out IDchosenSkin);
                    if (IDchosenSkin < PublicValues.skinURLs.Count)
                    {
                        var chosenSkinURL = PublicValues.skinURLs[IDchosenSkin];
                        Console.WriteLine("");
                        Console.WriteLine(GetSkinName.SkinName(chosenSkinURL));
                        Console.WriteLine("");
                        foreach (var wear in PublicValues.wears)
                        {
                            var price = GetDefaultPrices.getPrice(chosenSkinURL, wear, PublicValues.defaultEndPrice);
                            if (price == "No item in the market" || price == "Condition not Possible")
                            {
                                Console.WriteLine(PublicValues.wearNames[wearCount] + " = " + price);
                            }
                            else
                            {
                                Console.WriteLine(PublicValues.wearNames[wearCount] + " = $" + price);
                            }
                            wearCount++;
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Druk op R op opnieuw te proberen");
                        var reaction = Console.ReadKey();
                        if (reaction.KeyChar == 'r')
                        {
                            Console.WriteLine("");
                            searchSkin();
                        }
                        else
                        {
                            Console.WriteLine("Weet u Zeker dat u af wilt sluiten?");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Keuze is ongeldig");
                        Console.WriteLine("Druk op R op opnieuw te proberen");
                        var reaction = Console.ReadKey();
                        if (reaction.KeyChar == 'r')
                        {
                            Console.WriteLine("");
                            searchSkin();
                        }
                        else
                        {
                            Console.WriteLine("Weet u Zeker dat u af wilt sluiten?");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Keuze is ongeldig");
                    Console.WriteLine("Druk op R op opnieuw te proberen");
                    var reaction = Console.ReadKey();
                    if (reaction.KeyChar == 'r')
                    {
                        Console.WriteLine("");
                        searchSkin();
                    }
                    else
                    {
                        Console.WriteLine("Weet u Zeker dat u af wilt sluiten?");
                    }
                }
            }
            else
            {
                Console.WriteLine("Keuze is ongeldig");
                Console.WriteLine("Druk op R op opnieuw te proberen");
                var reaction = Console.ReadKey();
                if (reaction.KeyChar == 'r')
                {
                    Console.WriteLine("");
                    searchSkin();
                }
                else
                {
                    Console.WriteLine("Weet u Zeker dat u af wilt sluiten?");
                }
            }
            Console.ReadKey();
        }
    }
}
