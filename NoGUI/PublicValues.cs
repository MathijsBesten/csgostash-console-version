using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoGUI
{
    public class PublicValues
    {
        public static string fn = "New</span>\n\t\t<span class=\"pull-right\">";
        public static string mm = "Wear</span>\n\t\t<span class=\"pull-right\">";
        public static string ft = "Field-Tested</span>\n\t\t<span class=\"pull-right\">";
        public static string ww = "Well-Worn</span>\n\t\t<span class=\"pull-right\">";
        public static string bs = "Battle-Scarred</span>\n\t\t<span class=\"pull-right\">";

        public static string fnOPskins = "btn btn-default btn-sm opskins-button\" data-gaevent=\"MAG-7 Heat\">\n\t\t<span class=\"pull-left\">Factory New</span>\n\t\t<span class=\"pull-right\">";
        public static string mmOPskins = "btn btn-default btn-sm opskins-button\" data-gaevent=\"MAG-7 Heat\">\n\t\t<span class=\"pull-left\">Minimal Wear</span>\n\t\t<span class=\"pull-right\">";
        public static string ftOPskins = "btn btn-default btn-sm opskins-button\" data-gaevent=\"MAG-7 Heat\">\n\t\t<span class=\"pull-left\">Field-Tested</span>\n\t\t<span class=\"pull-right\">";
        public static string wwOPskins = "btn btn-default btn-sm opskins-button\" data-gaevent=\"MAG-7 Heat\">\n\t\t<span class=\"pull-left\">Well-Worn</span>\n\t\t<span class=\"pull-right\">";
        public static string bsOPskins = "btn btn-default btn-sm opskins-button\" data-gaevent=\"MAG-7 Heat\">\n\t\t<span class=\"pull-left\">Battle-Scarred</span>\n\t\t<span class=\"pull-right\">";

        public static List<string> wears = new List<string> { fn, mm, ft, ww, bs, };
        public static List<string> wearNames = new List<string> { "Factory New", "Minimal Wear", "Field-Tested", "Well-Worn", "Battle-Scarred" };

        public static string defaultStartName = "and collection info.\">\n<title>";
        public static string defaultEndName = " - CS:GO Stash</title>";
        public static string defaultEndPrice = "&euro;</span>";

        public static string defaultStartSkinInCategorie = "<div class=\"price\">\n\t<p class=\"nomargin\"><a href=\"";
        public static string defaultEndSkinInCategorie = "\" data-toggle=\"tooltip\"";
        public static List<string> Pistols = new List<string> { "CZ75-Auto", "Desert Eagle", "Dual Berettas", "Five-SeveN", "Glock-18", "P2000", "P250", "R8 Revolver", "Tec-9", "USP-S" };
        public static List<string> Rifles = new List<string> { "AK-47", "AUG", "AWP", "FAMAS", "G3SG1", "Galil AR", "M4A1-S", "M4A4", "SCAR-20", "SG+553", "SSG+08" };
        public static List<string> SMGs = new List<string> { "MAC-10", "MP7", "MP9", "PP-Bizon", "P90", "UMP-45" };
        public static List<string> Heavy = new List<string> { "MAG-7", "Nova", "Sawed-Off", "XM1014", "M249", "Negev" };
        public static List<List<string>> gunCategories = new List<List<string>> { Pistols, Rifles, SMGs, Heavy };
        public static List<string> gunCategoriesNames = new List<string> { "Pistols", "Rifles", "SMGs", "Heavy"};

        public static List<string> skinURLs =  new List<string>{};
        public static string priceFile = "D:\\pricelist.txt";


    }
}
