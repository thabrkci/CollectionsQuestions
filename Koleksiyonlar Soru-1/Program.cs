using System;
using System.Collections;


namespace Ödev__2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen 20 Adet pozitif sayı giriniz :)");
        ArrayList asal = new ArrayList();
        ArrayList asalolmayan = new ArrayList();
        int number = 20;
        for (int i = 0; i < number; i++)
        {
         Console.Write($" Lütfen {i+1}. sayıyı giriniz:");
         int Input;
         while(!int.TryParse(Console.ReadLine(), out Input) || Input<=0)
         {
          Console.WriteLine(" Hatalı giriş yaptınız,lütfen pozitif bir sayı giriniz !");
          Console.Write($"Lütfen {i+1}.Sayıyı giriniz:");
         }

          if(IsAsal(Input))
          {
            asal.Add(Input);
            Console.WriteLine($"{Input} asal bir sayıdır.");
            /* Bu ifadedeki (IsAsal(Input)) parantez C# dilinde ifadenin önceliğini belirtmek için kullanılır.
            Parantez içindeki ifade önce değerlendirilir ve bu değerlendirme sonucu if koşulunu oluşturur.Bu durumda ifadedeki
            parantez IsAsal fonksiyonunun "Input" parametresiyle çağrılmasıyla ifade eder.Eğer parantez olmasaydı "IsAsal" 
            fonksiyonu çağrılırken "Input" parametresi yalnızca "IsAsal Input" olarak değerlendirilebilirdi ki by geçerli bir ifade
            değildir.Bu nedenle, parantezler, ifadelerin doğru bir şekilde değerlendirilmesini ve ifade,içindeki öncelikleri belirtmek için kullanılır. 
            Bu durumda parantez, IsAsal fonksiyonunu çağırırken Input parametresini doğru bir şekilde ifade etmek için eklenmiştir. */
          }
          else
          {
            asalolmayan.Add(Input);
            Console.WriteLine($"{Input} asal bir sayı değildir.");
          }
          
         
        }
        Console.WriteLine("**********Asal olmayan sayılar***********");
        int[]sword = (int[])asalolmayan.ToArray(typeof(int));
        Array.Sort(sword);
        Array.Reverse(sword);
        foreach (var item in sword)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("*********Asal Olan Sayılar*********");
        int[]array =(int[])asal.ToArray(typeof(int));
        Array.Sort(array);
        Array.Reverse(array);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }/*-------------------------------------------------------------------------*/
        int toplamasalolmayan = asal.Count;
        Console.WriteLine("Asal olmayan sayıların toplam sayısı:" + toplamasalolmayan);
        int toplamasal = asalolmayan.Count;
        Console.WriteLine("Asal olan sayıların toplam sayısı" + toplamasal);
        /*------------------------------------------------------------------------*/
        double OrtalamaBulAsalolmayan = OrtalamaBul(asalolmayan);
        double ortalamaAsal = OrtalamaBul(asal);
        Console.WriteLine("Asal olmayan sayıların ortalaması"+ OrtalamaBulAsalolmayan);
        Console.WriteLine("Asal olan sayıların ortalaması"+ ortalamaAsal);
        
       
        static bool IsAsal(int sayi)
        {
         if (sayi < 2)
         return false;
         for (int i = 2; i < Math.Sqrt(sayi); i++)
         {
            if (sayi % i == 0)
            return false;
         }
            return true;


        }

        static double OrtalamaBul(ArrayList list)
        {
            int toplam = 0;
            foreach (var item in list)
            {
             toplam += (int)item;   
            }
            return (double)toplam / list.Count;
        }
        
        
        

        
        
    }
}
