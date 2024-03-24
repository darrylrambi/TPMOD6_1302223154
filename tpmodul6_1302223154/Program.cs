// See https://aka.ms/new-console-template for more information

class main
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Darryl_Rambi]");
        video.IncreasePlayCount(2);
        video.PrintVideoDetails();
    }
}