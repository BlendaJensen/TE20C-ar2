using System;

namespace Interaktiv_berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berättar vad det handlar om
            Console.Write("Välkomen till spelet, du försöker komma undan en mördare och för att leva måste du göra rätt val. Om du vill stanna där du är skriv stanna. Om du vill gå fram skriv fram: ");
            string rörelseEtt = Console.ReadLine().ToLower();
            
            //Vad som händer om man stannar
            if ( rörelseEtt == "stanna")
            {
                Console.WriteLine("Du dog och det blir ett olöst mordfall");
                Console.WriteLine("Du förlorade!");
            }
            //Vad som händer om man fortsätter fram
            if (rörelseEtt == "fram")
            {
                Console.WriteLine("Du kommer fram till ett hus med två dörrar, tar du vänster eller höger dörr?");
                string rörelseTvå = Console.ReadLine().ToLower();
                
                if (rörelseTvå == "vänster")
                {
                    Console.WriteLine("Du kommer in till ett tomt rum och det finns ett hål i mitten. Går du fram till hålet?");
                    string rörelseTreV = Console.ReadLine().ToLower();
                    
                    if (rörelseTreV == "ja")
                    {
                        Console.WriteLine("Du går sakta fram till hålet. När du sätter dig ner och lutar över hålet så känns det som att en hand trycks mot din rygg och du faller ner i hålet.");
                        Console.Write("Du förlorade!");
                    }
                    else
                    {
                        Console.WriteLine("Du tycker att hålet är mistänksamt och väljer att inte att gå fram till hålet. Men du märker inte att någon kommer in i rummet och världen svartnar för dina ögon.");
                        Console.WriteLine("Du förlorade!");
                    }
                    if (rörelseTvå == "höger")
                    {
                        Console.WriteLine("Du kom in i ett rum som har en vägg full med tavlor, en stor dörr och en spegel. Vad går du till?");
                        string rörelseTreH = 
                    }
                }
            }
        }
    }
}
