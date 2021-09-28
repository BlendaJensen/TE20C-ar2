using System;

namespace Interaktiv_berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            //Berättar vad det handlar om och första valet
            Console.Write("Välkomen till spelet, du försöker komma undan en mördare och för att leva måste du göra rätt val. Du har två val att gå fram eller att stanna (stanna/fram): ");
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
                //Val
                Console.WriteLine("Du kommer fram till ett hus med två dörrar, tar du vänster eller höger dörr?(höger/vänster)");
                string rörelseTvå = Console.ReadLine().ToLower();
                
                //Vad som händer om man tar vänster
                if (rörelseTvå == "vänster")
                {
                    //val
                    Console.WriteLine("Du kommer in till ett tomt rum och det finns ett hål i mitten. Går du fram till hålet?(ja/nej) ");
                    string rörelseTreV = Console.ReadLine().ToLower();
                    
                    //Vad som händer om man går fram
                    if (rörelseTreV == "ja")
                    {
                        Console.WriteLine("Du går sakta fram till hålet. När du sätter dig ner och lutar över hålet så känns det som att en hand trycks mot din rygg och du faller ner i hålet.");
                        Console.Write("Du förlorade!");
                    }
                    //Vad som händer om man inte går fram
                    else
                    {
                        Console.WriteLine("Du tycker att hålet är mistänksamt och väljer att inte att gå fram till hålet. Men du märker inte att någon kommer in i rummet och världen svartnar för dina ögon.");
                        Console.WriteLine("Du förlorade!");
                    }
                }
                 //Vad som händer om man tar höger
                if (rörelseTvå == "höger")
                 {
                     //Val
                     Console.WriteLine("Du kom in i ett rum som har en vägg full med tavlor, en stor dörr och en spegel. Vad går du till? (tavlor/dörr/spegel)");
                     string rörelseTreH = Console.ReadLine().ToLower();
                      //Vad som händer om man väljer tavlor
                      if (rörelseTreH == "tavlor")
                      {
                          Console.WriteLine("Du går fram till tavlorna och tittar på dem de är gammla och slitna och medans du kollar på dem så trycker någoon en trasa emot ditt ansikte och världen svartnar");
                          Console.WriteLine("Du förlorade!");
                        }
                        
                      //Vad som händer om man väljer dörr
                       if (rörelseTreH == "dörr")
                       {
                          Console.WriteLine("Du går fram till dörren och trycker ner handtaget. Du ser mördaren!");
                          Console.WriteLine("Du förlorade!");
                        }
                      //Vad som händer om man väljer spegel
                       else
                       {
                          Console.WriteLine("Du går fram till spegeln och ser din spegel bild. Du ser plötsligt att det kommer en skugga som sakta närmar sig. När skuggan kommer tillräkligt nära rycker du ner spegeln och springer ut ur rummet. Du tar den närmaste dörren och kommer ut ur huset.");
                          Console.WriteLine("Grattis, du vann!");
                        }
                        
                    }
            }
        }
    }
}
