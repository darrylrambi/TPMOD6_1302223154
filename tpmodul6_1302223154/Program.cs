// See https://aka.ms/new-console-template for more information

class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hasil Default");
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Darryl_Rambi]");
        video.IncreasePlayCount(2);
        video.PrintVideoDetails();

        Console.WriteLine(" ");

        Console.WriteLine("Test 100 char");
        SayaTubeVideo check = new SayaTubeVideo("Tutorial Design By Contract - [Video dengan judul lebih dari 100 karakter akan dipotong menjadi 100 karakter, termasuk yang lebih panjang dari 100 karakter]");

        Console.WriteLine(" ");

        SayaTubeVideo check2 = new SayaTubeVideo("Tutorial Design By Contract - [Darryl_Rambi]");
        Console.WriteLine("Test 10jt");
        check2.IncreasePlayCount(10000000);
        check2.PrintVideoDetails();

        Console.WriteLine(" ");

        Console.WriteLine("Test batas integer");
        for (int i = 0; i < 5; i++)
        {
            check.IncreasePlayCount(999999999);
        }
        check.PrintVideoDetails();
    }
}