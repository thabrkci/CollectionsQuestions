Console.WriteLine("Hello, World!");
//Klavyeden bir cümle girişi sağlayan kısım.
Console.WriteLine("Bir cümle giriniz:");
        string cumle = Console.ReadLine();

        char[] sesliHarfler = cumle.ToLower().Where(IsSesliHarf).Distinct().ToArray();

        Console.WriteLine("Cümledeki sesli harfler:");
        PrintArray(sesliHarfler);

        Array.Sort(sesliHarfler);

        Console.WriteLine("Sıralanmış sesli harfler:");
        PrintArray(sesliHarfler);
static bool IsSesliHarf(char harf)
    {
        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        return sesliHarfler.Contains(harf);
    }

    static void PrintArray(char[] array)
    {
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
