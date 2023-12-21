using System.Collections;

namespace Koleksiyonlar_Soru_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen 20 adet sayı giriniz !");
        ArrayList bigvalue = new ArrayList();
        ArrayList smallvalue = new ArrayList();

        int[] value = new int[20]; 
        
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($" Lütfen {i+1}.Sayıyı giriniz:");
            while(!int.TryParse(Console.ReadLine(), out value[i]))
            {
                Console.WriteLine("Hatalı giriş lütfen geçerli bir sayı giriniz ");
                Console.Write($"Lütfen {i+1}.Sayıyı giriniz:");
            }
        }
        Console.WriteLine("/----------------Girmiş olduğunuz sayılar-------------------/");
        foreach (var item in value)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("/-------------------------------------------------------------------/");

        Array.Sort(value);
        int[] minThree = new int[3];
        Array.Copy(value, minThree, 3);

        int[] maxThree = new int[3];
        Array.Copy(value, value.Length - 3, maxThree, 0,3);
        
        double minThreeAvarage = Calculating(minThree);
        double maxThreeAvarage = Calculating(maxThree);
        double overallAvarage = Calculating(value);
        
        Console.WriteLine("En küçük 3 sayı:");
        PrintArray(minThree);

        Console.WriteLine("En büyük 3 sayı:");
        PrintArray(maxThree);
        
        Console.WriteLine($"En küçük 3 sayı ortalaması: {minThreeAvarage}");
        Console.WriteLine($"En büyük 3 sayı ortalaması: {maxThreeAvarage}");
        Console.WriteLine($"Tüm sayıların ortalaması: {overallAvarage}");





        static double Calculating(int[] array)
        {
            int sum =0;
            foreach (var num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }


        static void PrintArray(int[] array)
        {
          foreach (var num in array)
          {
            Console.Write($"{num}");
          }
          Console.WriteLine();

        }
    }
}
