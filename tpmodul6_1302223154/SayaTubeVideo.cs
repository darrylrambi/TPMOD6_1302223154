using System;

public class SayaTubeVideo
{
	private int id;
	private string title;
	private int playCount;
    private static Random random = new Random();

    public SayaTubeVideo(string judul)
	{
		if (string.IsNullOrEmpty(judul) || judul.Length > 100)
		{
			Console.WriteLine("Invalid Input");
		} else
		{
            id = random.Next(10000, 99999);
            title = judul;
            playCount = 0;
        }
	}

	public void IncreasePlayCount(int tambahan)
	{
        try
        {
            checked
            {
                this.playCount = playCount + tambahan;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Input Overflow");
        }
    }

	public void PrintVideoDetails()
	{
		Console.WriteLine("ID Video: " + id);
        Console.WriteLine("Title Video: " + title);
        Console.WriteLine("PlayCount Video: " + playCount);
    }
}
