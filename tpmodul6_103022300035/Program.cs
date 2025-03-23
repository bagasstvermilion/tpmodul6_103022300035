using tpmodul6_103022300035;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Bagas Pratama");

        video.PrintVideoDetails();
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}