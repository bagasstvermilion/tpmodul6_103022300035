using tpmodul6_103022300035;

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Bagas Pratama");

            video.PrintVideoDetails();
            video.IncreasePlayCount(10000000);
            video.PrintVideoDetails();

            video.IncreasePlayCount(int.MaxValue);
            video.PrintVideoDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Terjadi error: {e.Message}");
        }
    }
}
