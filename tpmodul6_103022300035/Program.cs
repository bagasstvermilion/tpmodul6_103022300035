using tpmodul6_103022300035;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Bagas Pratama");

        video.PrintVideoDetails();
        video.IncreasePlayCount(10000000);
        video.PrintVideoDetails();
        Console.WriteLine();

        video.IncreasePlayCount(int.MaxValue);
        Console.WriteLine();
        video.PrintVideoDetails();
    }
}