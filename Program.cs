using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Periodic_Table_Master
{

    class Program
    {
        static void Main(string[] args)
        {
            String choice;
            String name;
            String EXIT;
            System.Windows.Forms.MessageBox.Show("Welcome to Periodic Table Master\n\nGet Details about any Element in MODERN PERIODIC TABLE\n\nFeedBack : www.facebook.com/arslan.ud.din\n\nOfficial Website : www.imarslan.com", "Built & Designed by Arslan Malik", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
            System.Windows.Forms.MessageBox.Show("Important Instructions\n\n1. You can get details using ATOMIC NUMBER\n2. You can get details using SYMBOLS\n3. You can get details using name of ELEMENTS\n4. Write 'EXIT' to end the program\n\n            BEST OF LUCK   ", "Built & Designed by Arslan Malik", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            {
            phir:
                Console.WriteLine("Enter Name of Element OR its Symbol OR Atomic Number");
                name = Console.ReadLine();
                switch (name)
                {
                    case "ac":
                    case "Ac":
                    case "AC":
                    case "ACTINIUM":
                    case "actinium":
                    case "Actinium":
                    case "89":
                        Console.WriteLine("\n\nSymbol : Ac\nName : Actinium\nAtomic Number : 89\nDerieved From : Greek , aktis = ray\nDiscovered by Debierne in 1899");
                        break;
                    case "Ag":
                    case "ag":
                    case "Silver":
                    case "Argentum":
                    case "47":
                    case "silver":
                    case "SILVER":
                    case "ARGENTUM":
                    case "argentum":
                        Console.WriteLine("\n\nSymbol : Ag\nName : Silver (Argentum)\nAtomic Number : 47\nDerieved From : Anglo-Saxon , seolfor , aktis = ray\nDiscovered : Prehistoric");
                        break;
                    case "Al":
                    case "al":
                    case "Aluminium":
                    case "13":
                        Console.WriteLine("\n\nSymbol : Al\nName : Aluminium\nAtomic Number : 13\nDerieved From : Latin , alumen = alum\nDiscovered by Wholer in 1828");
                        break;
                    case "Am":
                    case "am":
                    case "Americium":
                    case "95":
                        Console.WriteLine("\n\nSymbol : Am\nName : Americium\nAtomic Number : 95\nDerieved From : America\nDiscovered by Seoborg , James & others in 1944");
                        break;
                    case "Ar":
                    case "ar":
                    case "Argon":
                    case "18":
                        Console.WriteLine("\n\nSymbol : Ar\nName : Argon\nAtomic Number : 18\nDerieved From : Greek , argos = inactive\nDiscovered by Rayleigh & Ramsay in 1894");
                        break;
                    case "As":
                    case "as":
                    case "Arsenic":
                    case "33":
                    case "AS":
                        Console.WriteLine("\n\nSymbol : As\nName : Arsenic\nAtomic Number : 33\nDerieved From : Latin , arsenicum\nDiscovered by Schroder in 1649");
                        break;
                    case "At":
                    case "at":
                    case "AT":
                    case "Astatine":
                    case "85":
                        Console.WriteLine("\n\nSymbol : At\nName : Astatine\nAtomic Number : 85\nDerieved From : Greek , astatos = unstable \nDiscovered by Corson , Mackenzie & Segre in 1940");
                        break;
                    case "Au":
                    case "au":
                    case "AU":
                    case "AURUM":
                    case "aurum":
                    case "Aurum":
                    case "GOLD":
                    case "gold":
                    case "Gold":
                        Console.WriteLine("\n\nSymbol : Au\nName : Gold (Aurum)\nAtomic Number : 79\nDerieved From : Anglo-Saxon , gold\nDiscovered : Prehistoric");
                        break;
                    case "B":
                    case "b":
                    case "Boron":
                    case "BORON":
                    case "boron":
                    case "5":
                        Console.WriteLine("\n\nSymbol : B\nName : Boron\nAtomic Number : 5\nDerieved From : Persian , burah\nDiscovered by Davy in 1808");
                        break;
                    case "Ba":
                    case "BA":
                    case "ba":
                    case "Barium":
                    case "BARIUM":
                    case "barium":
                    case "56":
                        Console.WriteLine("\n\nSymbol : Ba\nName : Barium\nAtomic Number : 56\nDerieved From : Greek , barys = heavy\nDiscovered by Davy in 1808");
                        break;
                    case "Beryllium":
                    case "beryllium":
                    case "BERYLLIUM":
                    case "glucinum":
                    case "GLUCINUM":
                    case "Glucinum":
                    case "Be":
                    case "be":
                    case "BE":
                    case "4":
                        Console.WriteLine("\n\nSymbol : Be\nName : Beryllium (Glucinum)\nAtomic Number : 4\nDerieved From : Greek , beryllion = beryl\nDiscovered by Wholer in 1828");
                        break;
                    case "Bi":
                    case "bi":
                    case "BI":
                    case "Bismuth":
                    case "BISMUTH":
                    case "bismuth":
                    case "83":
                        Console.WriteLine("\n\nSymbol : Bi\nName : Bismuth\nAtomic Number : 83\nDerieved From : German (origin unknown)\nDiscovered by Valentine in 1450");
                        break;
                    case "Berkelium":
                    case "berkelium":
                    case "BERKELIUM":
                    case "BK":
                    case "bk":
                    case "Bk":
                    case "97":
                        Console.WriteLine("\n\nSymbol : Bk\nName : Berkelium\nAtomic Number : 97\nDerieved From : Berkeley , California \nDiscovered in 1950");
                        break;
                    case "Bromine":
                    case "BROMINE":
                    case "bromine":
                    case "35":
                    case "BR":
                    case "Br":
                    case "br":
                        Console.WriteLine("\n\nSymbol : Br\nName : Bromine\nAtomic Number : 35\nDerieved From : Greek , bromos = stench\nDiscovered by Balard in 1826");
                        break;
                    case "C":
                    case "c":
                    case "Carbon":
                    case "carbon":
                    case "CARBON":
                    case "6":
                        Console.WriteLine("\n\nSymbol : C\nName : Carbon\nAtomic Number : 6\nDerieved From : Latin , Carbo = Charcoal\nDiscovered : Prehistoric");
                        break;
                    case "Ca":
                    case "ca":
                    case "CA":
                    case "calcium":
                    case "CALCIUM":
                    case "Calcium":
                    case "20":
                        Console.WriteLine("\n\nSymbol : Ca\nName : Calcium\nAtomic Number : 89\nDerieved From : Latin , calx = lime\nDiscovered by Davy in 1808");
                        break;
                    case "cd":
                    case "CD":
                    case "Cd":
                    case "Cadmium":
                    case "CADMIUM":
                    case "cadmium":
                    case "48":
                        Console.WriteLine("\n\nSymbol : Cd\nName : Cadmium\nAtomic Number : 48\nDerieved From : Greek , kadmeia = calamine\nDiscovered by Stromeyer in 1817");
                        break;
                    case "Ce":
                    case "CE":
                    case "ce":
                    case "Cerium":
                    case "CERIUM":
                    case "cerium":
                    case "58":
                        Console.WriteLine("\n\nSymbol : Ce\nName : Cerium\nAtomic Number : 58\nDerieved From : Asteroid Ceres\nDiscovered by Berzelius in 1803");
                        break;
                    case "98":
                    case "Cf":
                    case "cf":
                    case "CF":
                    case "Californium":
                    case "CALIFORNIUM":
                    case "californium":
                        Console.WriteLine("\n\nSymbol : Cf\nName : Californium\nAtomic Number : 98\nDerieved From : California\nDiscovered in 1950");
                        break;
                    case "Cl":
                    case "cl":
                    case "CL":
                    case "Chlorine":
                    case "chlorine":
                    case "CHLORINE":
                    case "17":
                        Console.WriteLine("\n\nSymbol : Cl\nName : Chlorine\nAtomic Number : 17\nDerieved From : Greek , chloros = green\nDiscovered by Sheele in 1774");
                        break;
                    case "Curium":
                    case "curium":
                    case "CURIUM":
                    case "96":
                    case "cm":
                    case "CM":
                    case "Cm":
                        Console.WriteLine("\n\nSymbol : Cm\nName : Curium\nAtomic Number : 96\nDerieved From : Pierre & Maire Curie\nDiscovered by Seoberg , James & others in 1944");
                        break;
                    case "Co":
                    case "CO":
                    case "co":
                    case "Cobalt":
                    case "cobalt":
                    case "COBALT":
                    case "27":
                        Console.WriteLine("\n\nSymbol : Co\nName : Cobalt\nAtomic Number : 27\nDerieved From : German , kobold = globin\nDiscovered by Brandt in 1739");
                        break;
                    case "Cr":
                    case "cr":
                    case "CR":
                    case "Chromium":
                    case "chromium":
                    case "CHROMIUM":
                    case "24":
                        Console.WriteLine("\n\nSymbol : Cr\nName : Chromium\nAtomic Number : 24\nDerieved From : Greek , chroma = colour\nDiscovered by Vauquelin in 1797");
                        break;
                    case "Caesium":
                    case "caesium":
                    case "CAESIUM":
                    case "CS":
                    case "cs":
                    case "Cs":
                    case "55":
                        Console.WriteLine("\n\nSymbol : Cs\nName : Caesium\nAtomic Number : 55\nDerieved From : Latin , caesium = bluish grey\nDiscovered by Bunsen in 1860");
                        break;
                    case "Cu":
                    case "cu":
                    case "CU":
                    case "Copper":
                    case "COPPER":
                    case "copper":
                    case "cuprum":
                    case "Cuprum":
                    case "CUPRUM":
                    case "29":
                        Console.WriteLine("\n\nSymbol : Cu\nName : Copper (Cuprum)\nAtomic Number : 29\nDerieved From : Cyprus\nDiscovered : Prehistoric");
                        break;
                    case "Dysprosium":
                    case "66":
                    case "DYSPROSIUM":
                    case "dysprosium":
                    case "Dy":
                    case "dy":
                    case "DY":
                        Console.WriteLine("\n\nSymbol : Dy\nName : Dysprosium\nAtomic Number : 66\nDerieved From : Greek , dysprositos = difficult to reach\nDiscovered by Biosbaudran in 1886");
                        break;
                    case "Er":
                    case "er":
                    case "ER":
                    case "Erbium":
                    case "ERBIUM":
                    case "erbium":
                    case "68":
                        Console.WriteLine("\n\nSymbol : Er\nName : Erbium\nAtomic Number : 68\nDerieved From : Ytterby , A Swidish Town\nDiscovered by Mosander in 1843");
                        break;
                    case "Es":
                    case "es":
                    case "ES":
                    case "Einsteinium":
                    case "EINSTEINIUM":
                    case "einsteinium":
                    case "99":
                        Console.WriteLine("\n\nSymbol : Es\nName : Einsteinium\nAtomic Number : 99\nDerieved From : Einstein\nDiscovered in 1952");
                        break;
                    case "EU":
                    case "eu":
                    case "Eu":
                    case "Europium":
                    case "EUROPIUM":
                    case "europium":
                    case "63":
                        Console.WriteLine("\n\nSymbol : Eu\nName : Europium\nAtomic Number : 63\nDerieved From : Europe + ium \nDiscovered by Demarcay in 1896");
                        break;
                    case "F":
                    case "f":
                    case "flourine":
                    case "FLOURINE":
                    case "Flourine":
                    case "9":
                        Console.WriteLine("\n\nSymbol : F\nName : Flourine\nAtomic Number : 9\nDerieved From : Latin , fluo = flow\nDiscovered : Prehistoric");
                        break;
                    case "Fe":
                    case "fe":
                    case "FE":
                    case "Ferrum":
                    case "ferrum":
                    case "FERRUM":
                    case "Iron":
                    case "iron":
                    case "IRON":
                    case "26":
                        Console.WriteLine("\n\nSymbol : Fe\nName : Iron (Ferrum)\nAtomic Number : 26\nDerieved From : anglo-saxon , iren \nDiscovered : Prehistoric");
                        break;
                    case "Fm":
                    case "fm":
                    case "FM":
                    case "Fermium":
                    case "FERMIUM":
                    case "fermium":
                    case "100":
                        Console.WriteLine("\n\nSymbol : Fm\nName : Fermium\nAtomic Number : 100\nDerieved From :  fermi\nDiscovered in 1952 ");
                        break;
                    case "fr":
                    case "FR":
                    case "Fr":
                    case "francium":
                    case "Francium":
                    case "FRANCIUM":
                    case "87":
                        Console.WriteLine("\n\nSymbol : Fr\nName : Francium\nAtomic Number : 87\nDerieved From :  ,  = \nDiscovered by Mlle Perey in 1939");
                        break;
                    case "Ga":
                    case "GA":
                    case "ga":
                    case "Gallium":
                    case "GALLIUM":
                    case "gallium":
                    case "31":
                        Console.WriteLine("\n\nSymbol : Ga\nName : Gallium\nAtomic Number : 31\nDerieved From : Latin , Gallia = France\nDiscovered by  in ");
                        break;
                    case "Gadolinium":
                    case "gadolinium":
                    case "GADOLINIUM":
                    case "Gd":
                    case "GD":
                    case "gd":
                    case "64":
                        Console.WriteLine("\n\nSymbol : Gd\nName : Gadolinium\nAtomic Number : 64\nDerieved From : Gadolin , a Finnish  chemist = \nDiscovered by Marignac in 1880 ");
                        break;
                    case "GE":
                    case "ge":
                    case "Ge":
                    case "Germanium":
                    case "germanium":
                    case "GERMANIUM":
                    case "32":
                        Console.WriteLine("\n\nSymbol : Ge\nName : Germanium\nAtomic Number : 32\nDerieved From : Latin , Germania = Germany\nDiscovered by  in ");
                        break;
                    case "H":
                    case "h":
                    case "Hydrogen":
                    case "HYDROGEN":
                    case "hydrogen":
                    case "1":
                        Console.WriteLine("\n\nSymbol : H\nName : Hydrogen\nAtomic Number : 1\nDerieved From : Greek , hydor = water + gennaein , to produce\nDiscovered by Cavendish ");
                        break;
                    case "Hahnium":
                    case "105":
                    case "hahnium":
                    case "HAHNIUM":
                    case "Ha":
                    case "ha":
                    case "HA":
                        Console.WriteLine("\n\nSymbol : Ha\nName : Hahnium\nAtomic Number : 105\nDerieved From : Otto Hahn , German Nuclear Physicist\nDiscovered by Lawrence Radiation Laboratory , University of California in 1970");
                        break;
                    case "He":
                    case "he":
                    case "HE":
                    case "Helium":
                    case "helium":
                    case "HELIUM":
                    case "2":
                        Console.WriteLine("\n\nSymbol : He\nName : Helium\nAtomic Number : 2\nDerieved From : Greek , helios = sun\nDiscovered by Ramsay in 1895");
                        break;
                    case "Hf":
                    case "hf":
                    case "HF":
                    case "Hafnium":
                    case "hafnium":
                    case "HAFNIUM":
                    case "72":
                        Console.WriteLine("\n\nSymbol : Hf\nName : Hafnium\nAtomic Number : 72\nDerieved From : Hafnia , Copenhegen = \nDiscovered by Coster & Hevesey in 1923");
                        break;
                    case "Hg":
                    case "hg":
                    case "HG":
                    case "Mercury":
                    case "MERCURY":
                    case "mercury":
                    case "hydrargyrum":
                    case "HYDRARGYRUM":
                    case "Hydrargyrum":
                    case "80":
                        Console.WriteLine("\n\nSymbol : Hg\nName : Mercury (Hydrargyrum)\nAtomic Number : 80\nDerieved From : Mercury (myth) \nDiscovered : Prehistoric ");
                        break;
                    case "Ho":
                    case "Holomium":
                    case "holomium":
                    case "HOLOMIUM":
                    case "ho":
                    case "HO":
                    case "67":
                        Console.WriteLine("\n\nSymbol : Ho\nName : Holomium\nAtomic Number : 67\nDerieved From : Holmia = Stockholm\nDiscovered by Cleve in 1879");
                        break;
                    case "I":
                    case "i":
                    case "53":
                    case "Iodine":
                    case "iodine":
                    case "IODINE":
                        Console.WriteLine("\n\nSymbol : I\nName : Iodine\nAtomic Number : 53\nDerieved From : Greek , iodes = violet\nDiscovered by Courtois in 1811");
                        break;
                    case "In":
                    case "IN":
                    case "in":
                    case "indium":
                    case "Indium":
                    case "INDIUM":
                    case "49":
                        Console.WriteLine("\n\nSymbol : In\nName : Indium\nAtomic Number : 49\nDerieved From : Its indigo spectrum\nDiscovered by Reich & Richter in 1863");
                        break;
                    case "Iridium":
                    case "IRIDIUM":
                    case "iridium":
                    case "Ir":
                    case "ir":
                    case "IR":
                    case "77":
                        Console.WriteLine("\n\nSymbol : Ir\nName : Iridium\nAtomic Number : 77\nDerieved From : Latin , iris = a rainbow\nDiscovered by Tennant in 1803");
                        break;
                    case "K":
                    case "k":
                    case "Potassium":
                    case "potassium":
                    case "POTASSIUM":
                    case "KALIUM":
                    case "kalium":
                    case "Kalium":
                    case "19":
                        Console.WriteLine("\n\nSymbol : K\nName : Potassium\nAtomic Number : 19\nDerieved From : English ,  potash \nDiscovered by Davy in 1807");
                        break;
                    case "Kr":
                    case "kr":
                    case "KR":
                    case "Krypton":
                    case "36":
                    case "krypton":
                    case "KRYPTON":
                        Console.WriteLine("\n\nSymbol : Kr\nName : Krypton\nAtomic Number : 36\nDerieved From : Greek , kryptos  = hidden\nDiscovered by Ramsay & Travers in 1898");
                        break;
                    case "La":
                    case "la":
                    case "LA":
                    case "LANTHANUM":
                    case "Lanthanum":
                    case "lanthanum":
                    case "57":
                        Console.WriteLine("\n\nSymbol : La\nName : Lanthanum\nAtomic Number : \nDerieved From : Greek , lanthanein , to be unseen \nDiscovered by Mosander in 1839");
                        break;
                    case "Li":
                    case "li":
                    case "LI":
                    case "Lithium":
                    case "LITHIUM":
                    case "lithium":
                    case "3":
                        Console.WriteLine("\n\nSymbol : Li\nName : Lithium\nAtomic Number : 3\nDerieved From : Greek , lithos = stone\nDiscovered by Arfvedson in 1817");
                        break;
                    case "Lr":
                    case "lr":
                    case "LR":
                    case "Lawrencium":
                    case "LAWRENCIUM":
                    case "lawrencium":
                    case "103":
                        Console.WriteLine("\n\nSymbol : Lr\nName : Lawrencium\nAtomic Number : 103\nDerieved From : Lawrence\nDiscovered in 1961");
                        break;
                    case "LU":
                    case "lu":
                    case "Lu":
                    case "Lutetium":
                    case "LUTETIUM":
                    case "lutetium":
                    case "71":
                        Console.WriteLine("\n\nSymbol : Lu\nName : Lutetium\nAtomic Number : 71\nDerieved From : Lutetia , ancient name of Paris\nDiscovered by Urbain & Welsbach in 1907");
                        break;
                    case "Mendelevium":
                    case "Md":
                    case "md":
                    case "MD":
                    case "mendelevium":
                    case "MENDELEVIUM":
                    case "101":
                        Console.WriteLine("\n\nSymbol : Md\nName : Mendelevium\nAtomic Number : 101\nDerieved From : Mendeleev , Russian Chemist\nDiscovered in 1955");
                        break;
                    case "12":
                    case "Mg":
                    case "mg":
                    case "MG":
                    case "Magnesium":
                    case "magnesium":
                    case "MAGNESIUM":
                        Console.WriteLine("\n\nSymbol : Mg\nName : Magnesium\nAtomic Number : 12\nDerieved From : Magnesia , District in Thessaly  = \nDiscovered by Bussy in 1829");
                        break;
                    case "Mn":
                    case "mn":
                    case "MN":
                    case "Manganese":
                    case "manganese":
                    case "MANGANESE":
                    case "25":
                        Console.WriteLine("\n\nSymbol : Mn\nName : Manganese\nAtomic Number : 25\nDerieved From : Latin , magnes = magnet\nDiscovered by Gahn in 1774");
                        break;
                    case "Mo":
                    case "mo":
                    case "MO":
                    case "Molybdenum":
                    case "molybdenum":
                    case "MOLYBDENUM":
                    case "42":
                        Console.WriteLine("\n\nSymbol : Mo\nName : Molybdenum\nAtomic Number : 42\nDerieved From : Greek , molybdos  = lead \nDiscovered by Hjelm in 1782");
                        break;
                    case "N":
                    case "n":
                    case "Nitrogen":
                    case "NITROGEN":
                    case "nitrogen":
                    case "7":
                        Console.WriteLine("\n\nSymbol : N\nName : Nitrogen\nAtomic Number : 7\nDerieved From : Greek , nitron = saltpetre + gennaein , to produce\nDiscovered by D.Rutherford in 1772");
                        break;
                    case "Sodium":
                    case "SODIUM":
                    case "sodium":
                    case "natrium":
                    case "NATRIUM":
                    case "Natrium":
                    case "Na":
                    case "na":
                    case "NA":
                    case "11":
                        Console.WriteLine("\n\nSymbol : Na\nName : Sodium (Natrium)\nAtomic Number : 11\nDerieved From : English , soda \nDiscovered by Davy in 1807");
                        break;
                    case "Nb":
                    case "Niobium":
                    case "Columbium":
                    case "columbium":
                    case "COLUMBIUM":
                    case "nb":
                    case "NB":
                    case "NIOBIUM":
                    case "niobium":
                    case "41":
                        Console.WriteLine("\n\nSymbol : Nb\nName : Niobium (Columbium)\nAtomic Number : 41\nDerieved From : Niobe (Greek myth)\nDiscovered by Hatchett in 1801");
                        break;
                    case "Nd":
                    case "nd":
                    case "ND":
                    case "Neodymium":
                    case "NEODYMIUM":
                    case "neodymium":
                    case "60":
                        Console.WriteLine("\n\nSymbol : Nd\nName : Neodymium\nAtomic Number : 60\nDerieved From : Greek , neos = new & didymos = twin\nDiscovered by Welsbach in 1885");
                        break;
                    case "Ne":
                    case "ne":
                    case "NE":
                    case "Neon":
                    case "NEON":
                    case "neon":
                    case "10":
                        Console.WriteLine("\n\nSymbol : Ne\nName : Neon\nAtomic Number : 10\nDerieved From : Greek , neos = new\nDiscovered by Ramsay & Travers in 1898");
                        break;
                    case "Ni":
                    case "ni":
                    case "NI":
                    case "Nickel":
                    case "NICKEL":
                    case "nickel":
                    case "28":
                        Console.WriteLine("\n\nSymbol : Ni\nName : Nickel\nAtomic Number : 28\nDerieved From : Swedish , abbreviation of kuparnickel \nDiscovered by Cronstredt in 1751");
                        break;
                    case "No":
                    case "NO":
                    case "no":
                    case "Nobelium":
                    case "nobelium":
                    case "NOBELIUM":
                    case "102":
                        Console.WriteLine("\n\nSymbol : No\nName : Nobelium\nAtomic Number : 102\nDerieved From : Nobel\nDiscovered in 1957");
                        break;
                    case "np":
                    case "Np":
                    case "NP":
                    case "Neptunium":
                    case "neptunium":
                    case "NEPTUNIUM":
                    case "93":
                        Console.WriteLine("\n\nSymbol : Np\nName : Neptunium\nAtomic Number : 93\nDerieved From :  Planet Neptune \nDiscovered by McMillan & Abelson in 1940");
                        break;
                    case "o":
                    case "O":
                    case "oxygen":
                    case "Oxygen":
                    case "OXYGEN":
                    case "8":
                        Console.WriteLine("\n\nSymbol : O\nName : Oxygen\nAtomic Number : 8\nDerieved From : Greek , oxys = acid + gennaein , to produce\nDiscovered by Priestley");
                        break;
                    case "Os":
                    case "OS":
                    case "os":
                    case "Osmium":
                    case "osmium":
                    case "OSMIUM":
                    case "76":
                        Console.WriteLine("\n\nSymbol : Os\nName : Osmium\nAtomic Number : 76\nDerieved From : Greek , osme = odour \nDiscovered by Tennant in 1803 ");
                        break;
                    case "P":
                    case "p":
                    case "15":
                    case "Phosphorous":
                    case "phosphorous":
                    case "PHOSPHOROUS":
                        Console.WriteLine("\n\nSymbol : P\nName : Phosphorous\nAtomic Number : 15\nDerieved From : Latin , from Greek word (Light-Bearing)\nDiscovered by Brandt in 1669");
                        break;
                    case "Pa":
                    case "PA":
                    case "pa":
                    case "Protactinium":
                    case "protactinium":
                    case "PTOTACTINIUM":
                    case "91":
                        Console.WriteLine("\n\nSymbol : Pa\nName : \nAtomic Number : 91\nDerieved From : Greek , protos = first + actinium\nDiscovered by Hahn & Meitner in 1917");
                        break;
                    case "pb":
                    case "Pb":
                    case "PB":
                    case "plumbum":
                    case "lead":
                    case "Plumbum":
                    case "PLUMBUM":
                    case "Lead":
                    case "LEAD":
                    case "82":
                        Console.WriteLine("\n\nSymbol : Pb\nName : Lead (Plumbum)\nAtomic Number : 82\nDerieved From : Anglo-Saxon  , Lead\nDiscovered : Prehistoric");
                        break;
                    case "Pd":
                    case "PD":
                    case "pd":
                    case "Palladium":
                    case "palladium":
                    case "PALLADIUM":
                    case "46":
                        Console.WriteLine("\n\nSymbol : Pd\nName : \nAtomic Number : 46\nDerieved From : Asteroid Pallas\nDiscovered by Wollaston in 1804");
                        break;
                    case "Pm":
                    case "PM":
                    case "pm":
                    case "Promethium":
                    case "promethium":
                    case "PROMETHIUM":
                    case "Illinium":
                    case "illinium":
                    case "ILLINIUM":
                    case "61":
                        Console.WriteLine("\n\nSymbol : Pm\nName : Promethium (illinium)\nAtomic Number : 61\nDerieved From : Prometheus , stealer of fire from heaven\nDiscovered by Clinton Laboratories, Oak Ridge , Tenn in 1940");
                        break;
                    case "Po":
                    case "PO":
                    case "po":
                    case "Polonium":
                    case "polonium":
                    case "POLONIUM":
                    case "84":
                        Console.WriteLine("\n\nSymbol : Po\nName : Polonium\nAtomic Number : 84\nDerieved From : Poland\nDiscovered by Mme Curie in 1898");
                        break;
                    case "Pr":
                    case "pr":
                    case "PR":
                    case "Praseodymium":
                    case "praseodymium":
                    case "PRASEODYMIUM":
                    case "59":
                        Console.WriteLine("\n\nSymbol : Pr\nName : Praseodymium\nAtomic Number : 59\nDerieved From : Greek , prasios = green & didymos = twin\nDiscovered by Welsbach in 1885");
                        break;
                    case "pt":
                    case "Pt":
                    case "PT":
                    case "Platinum":
                    case "PLATINUM":
                    case "platinum":
                    case "78":
                        Console.WriteLine("\n\nSymbol : Pt\nName : Platinum\nAtomic Number : 78\nDerieved From : Spanish , platina = silver\nDiscovered by Wood in 1741");
                        break;
                    case "Pu":
                    case "pu":
                    case "PU":
                    case "Plutonium":
                    case "PLUTONIUM":
                    case "plutonium":
                    case "94":
                        Console.WriteLine("\n\nSymbol : Pu\nName : Plutonium\nAtomic Number : 94\nDerieved From : Planet Pluto\nDiscovered by Seaborg , McMillan , Wahl & Kennedy in 1940");
                        break;
                    case "Ra":
                    case "ra":
                    case "RA":
                    case "Radium":
                    case "RADIUM":
                    case "radium":
                    case "88":
                        Console.WriteLine("\n\nSymbol : Ra\nName : Radium\nAtomic Number : 88\nDerieved From : Latin , radius = ray\nDiscovered by Mme & M.Curie & Bemont in 1898");
                        break;
                    case "Rb":
                    case "rb":
                    case "RB":
                    case "Rubidium":
                    case "rubidium":
                    case "RUBIDIUM":
                    case "37":
                        Console.WriteLine("\n\nSymbol : Rb\nName : Rubidium\nAtomic Number : 37\nDerieved From : Latin , rubidus = red\nDiscovered by Bunsen in 1860");
                        break;
                    case "Re":
                    case "RE":
                    case "re":
                    case "Rhenium":
                    case "RHENIUM":
                    case "rhenium":
                    case "75":
                        Console.WriteLine("\n\nSymbol : Re\nName : Rhenium\nAtomic Number : 75\nDerieved From : German , Rhein\nDiscovered by Noddack & Tacke in 1925");
                        break;
                    case "Rf":
                    case "rf":
                    case "RF":
                    case "Rutherfordium":
                    case "RUTHERFORDIUM":
                    case "rutherfordium":
                    case "104":
                    case "kurchatovium":
                    case "Kurchatovium":
                    case "KURCHATOVIUM":
                        Console.WriteLine("\n\nSymbol : Rf\nName : Rutherfordium (Kurchatovium)\nAtomic Number : 104\nDerieved From : Lord Rutherford\nDiscovered by Lawrence Radiation Laboratory,University of California in 1969");
                        break;
                    case "Rh":
                    case "rh":
                    case "RH":
                    case "Rhodium":
                    case "RHODIUM":
                    case "rhodium":
                    case "45":
                        Console.WriteLine("\n\nSymbol : Rh\nName : Rhodium\nAtomic Number : 45\nDerieved From : Greek , rhodon = rose\nDiscovered by Wollaston in 1804");
                        break;
                    case "Rn":
                    case "rn":
                    case "RN":
                    case "Radon":
                    case "Niton":
                    case "niton":
                    case "NITON":
                    case "RADON":
                    case "radon":
                    case "86":
                        Console.WriteLine("\n\nSymbol : Rn\nName : Radon (Niton)\nAtomic Number : 86\nDerieved From : Radium emanation\nDiscovered by Dorn in 1901");
                        break;
                    case "Ru":
                    case "Ruthenium":
                    case "ru":
                    case "RU":
                    case "RUTHENIUM":
                    case "ruthenium":
                    case "44":
                        Console.WriteLine("\n\nSymbol : Ru\nName : Ruthenium\nAtomic Number : 44\nDerieved From : Ruthenia\nDiscovered by Claus in 1845");
                        break;
                    case "S":
                    case "s":
                    case "Sulphur":
                    case "SULPHUR":
                    case "sulphur":
                    case "16":
                        Console.WriteLine("\n\nSymbol : S\nName : Sulphur\nAtomic Number : 16\nDerieved From : Latin , sulfur \nDiscovered : Prehistoric ");
                        break;
                    case "Sb":
                    case "sb":
                    case "SB":
                    case "Antimony":
                    case "stibium":
                    case "Stibium":
                    case "STIBIUM":
                    case "ANTIMONY":
                    case "antimony":
                    case "51":
                        Console.WriteLine("\n\nSymbol : Sb\nName : Antimony (Stibium)\nAtomic Number : 51\nDerieved From : L.Latin , antimonium\nDiscovered by Valentine in 1450");
                        break;
                    case "Sc":
                    case "SC":
                    case "sc":
                    case "Scandium":
                    case "SCANDIUM":
                    case "scandium":
                    case "21":
                        Console.WriteLine("\n\nSymbol : Sc\nName : Scandium\nAtomic Number : 21\nDerieved From :  Scandinavia \nDiscovered by Nilson in 1879");
                        break;
                    case "Se":
                    case "SE":
                    case "se":
                    case "Selenium":
                    case "SELENIUM":
                    case "selenium":
                    case "34":
                        Console.WriteLine("\n\nSymbol : Se\nName : Selenium\nAtomic Number : 34\nDerieved From : Greek , selene = moon\nDiscovered by Berzelius in 1817");
                        break;
                    case "Si":
                    case "si":
                    case "SI":
                    case "Silicon":
                    case "SILICON":
                    case "silicon":
                    case "14":
                        Console.WriteLine("\n\nSymbol : Si\nName : Silicon\nAtomic Number : 14\nDerieved From : Latin , silex = flint\nDiscovered by Berzelius in 1823");
                        break;
                    case "Sm":
                    case "Samarium":
                    case "SM":
                    case "sm":
                    case "samarium":
                    case "SAMARIUM":
                    case "62":
                        Console.WriteLine("\n\nSymbol : Sm\nName : Samarium\nAtomic Number : 62\nDerieved From : Samarski , a Russian savant = \nDiscovered by Biosbaudran in 1879");
                        break;
                    case "Sn":
                    case "sn":
                    case "SN":
                    case "Tin":
                    case "tin":
                    case "TIN":
                    case "Stannum":
                    case "stannum":
                    case "STANNUM":
                    case "50":
                        Console.WriteLine("\n\nSymbol : Sn\nName : Tin (Stannum)\nAtomic Number : 50\nDerieved From : Anglo-Saxon , tin\nDiscovered : Prehistoric");
                        break;
                    case "Sr":
                    case "SR":
                    case "sr":
                    case "Strontium":
                    case "STRONTIUM":
                    case "strontium":
                    case "38":
                        Console.WriteLine("\n\nSymbol : Sr\nName : Strontium\nAtomic Number : 38\nDerieved From : Strontian , a Scottish Village \nDiscovered by Davy in 1808");
                        break;
                    case "Ta":
                    case "ta":
                    case "TA":
                    case "Tantalum":
                    case "73":
                    case "tantalum":
                    case "TANTALUM":
                        Console.WriteLine("\n\nSymbol : Ta\nName : Tantalum\nAtomic Number : 73\nDerieved From : Tantalus (Greek myth) \nDiscovered by  in ");
                        break;
                    case "Tb":
                    case "tb":
                    case "TB":
                    case "Terbium":
                    case "terbium":
                    case "TERBIUM":
                    case "65":
                        Console.WriteLine("\n\nSymbol : Tb\nName : Terbium\nAtomic Number : 65\nDerieved From : Ytterby , a Swedish quarry \nDiscovered by Mosander in 1843");
                        break;
                    case "Tc":
                    case "tc":
                    case "TC":
                    case "Technetium":
                    case "Masurium":
                    case "technetium":
                    case "masurium":
                    case "TECHNETIUM":
                    case "MASURIUM":
                    case "43":
                        Console.WriteLine("\n\nSymbol : Tc\nName : Technetium (Masurium)\nAtomic Number : 43\nDerieved From : Greek , technetos = artificial\nDiscovered by Perrier & Segre in 1937");
                        break;
                    case "Te":
                    case "te":
                    case "TE":
                    case "Tellurium":
                    case "tellurium":
                    case "TELLURIUM":
                    case "52":
                        Console.WriteLine("\n\nSymbol : Te\nName : Tellurium\nAtomic Number : 52\nDerieved From : Latin , tellus = earth\nDiscovered by Reichenstein in 1782");
                        break;
                    case "Th":
                    case "TH":
                    case "th":
                    case "Thorium":
                    case "thorium":
                    case "THORIUM":
                    case "90":
                        Console.WriteLine("\n\nSymbol : Th\nName : Thorium\nAtomic Number : 90\nDerieved From : God Thor\nDiscovered by Berzelius in 1828");
                        break;
                    case "Ti":
                    case "ti":
                    case "TI":
                    case "Titanium":
                    case "TITANIUM":
                    case "titanium":
                    case "22":
                        Console.WriteLine("\n\nSymbol : Ti\nName : Titanium\nAtomic Number : 22\nDerieved From : Latin , Titanes = sons of the earth\nDiscovered by Gregor in 1789");
                        break;
                    case "Tl":
                    case "tl":
                    case "TL":
                    case "Thallium":
                    case "THALLIUM":
                    case "thallium":
                    case "81":
                        Console.WriteLine("\n\nSymbol : Tl\nName : Thallium\nAtomic Number : 81\nDerieved From : Greek , thallos = budding twig\nDiscovered by Crookes in 1862");
                        break;
                    case "Tm":
                    case "tm":
                    case "TM":
                    case "Thulium":
                    case "THULIUM":
                    case "thulium":
                    case "69":
                        Console.WriteLine("\n\nSymbol : Tm\nName : Thulium\nAtomic Number : 61\nDerieved From : Thule = Northland\nDiscovered by Cleve in 1879");
                        break;
                    case "U":
                    case "u":
                    case "Uranium":
                    case "uranium":
                    case "URANIUM":
                    case "92":
                        Console.WriteLine("\n\nSymbol : U\nName : Uranium\nAtomic Number : 92\nDerieved From : Planet Uranus\nDiscovered by Klaproth in 1789");
                        break;
                    case "V":
                    case "v":
                    case "Vanadium":
                    case "VANADIUM":
                    case "vanadium":
                    case "23":
                        Console.WriteLine("\n\nSymbol : V\nName : Vanadium\nAtomic Number : 23\nDerieved From : Goddess Vanadis (Freya)\nDiscovered by Sefstrom in 1830");
                        break;
                    case "W":
                    case "Tungsten":
                    case "tungsten":
                    case "w":
                    case "TUNGSTEN":
                    case "wolfram":
                    case "Wolfram":
                    case "WOLFRAM":
                    case "74":
                        Console.WriteLine("\n\nSymbol : W\nName : Tungsten (Wolfram)\nAtomic Number : 74\nDerieved From : Swedish ,  heavy stone \nDiscovered by d'Elhujar in 1781");
                        break;
                    case "Xe":
                    case "Xenon":
                    case "xe":
                    case "XE":
                    case "xenon":
                    case "XENON ":
                    case "54":
                        Console.WriteLine("\n\nSymbol : Xe\nName : Xenon\nAtomic Number : 54\nDerieved From : Greek , xenos = stranger\nDiscovered by Ramsay & Travers in 1898");
                        break;
                    case "Y":
                    case "Yttrium":
                    case "yttrium":
                    case "y":
                    case "YTTRIUM":
                    case "39":
                        Console.WriteLine("\n\nSymbol : Y\nName : Yttrium\nAtomic Number : 39\nDerieved From : Ytterby , a Swedish Town\nDiscovered by  in ");
                        break;
                    case "Yb":
                    case "Ytterbium":
                    case "yb":
                    case "YB":
                    case "YTTERBIUM":
                    case "ytterbium":
                    case "70":
                        Console.WriteLine("\n\nSymbol : Zb\nName : \nAtomic Number : 70\nDerieved From : Ytterby , a Swedish Town \nDiscovered by  in ");
                        break;
                    case "Zn":
                    case "Zinc":
                    case "zn":
                    case "ZN":
                    case "zinc":
                    case "ZINC":
                    case "30":
                        Console.WriteLine("\n\nSymbol : Zn\nName : Zinc\nAtomic Number : 30\nDerieved From : German , Zink \nDiscovered before 1500 ");
                        break;
                    case "Zr":
                    case "ZR":
                    case "zr":
                    case "ZIRCONIUM":
                    case "40":
                    case "zirconium":
                    case "Zirconium":
                        Console.WriteLine("\n\nSymbol : Zr\nName : Zirconium\nAtomic Number : 40\nDerieved From : Persian , zargun = gold-coloured\nDiscovered by Berzelius in 1824");
                        break;
                    case "EXIT":
                    case "exit":
                    case "Exit":
                    case "eXit":
                    case "exIt":
                    case "exiT":
                    case "EXIt":
                    case "EXiT":
                    case "ExIT":
                    case "eXIT":
                        return;
                    default:
                        Console.WriteLine("\n\a\nYou have enetered wrong information....");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\n\nDo you want to check details of another Element...???\n\n\nWrite Yes/No Below...!!!\n\n\n");
                choice = Console.ReadLine();
                if (choice == "NO" || choice == "nO" || choice == "No" || choice == "no")
                {
                    Console.Clear();
                    Console.WriteLine("Write Exit to end this program....");
                    EXIT = Console.ReadLine();
                    if (EXIT == "exit" || EXIT == "EXIT" || EXIT == "Exit")
                    {
                        return;
                    }

                }
                else
                {
                    Console.Clear();
                    goto phir;
                }
            }
        }
    }
}
