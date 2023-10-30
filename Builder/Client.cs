using Builder.Builders;
using Builder.Studios;

namespace Builder
{
    public static class Client
    {
        public static void Execute()
        {
            var director = new Director();

            StudioBuilder studioBuilder;
            Studio studio;

            studioBuilder = new Studio24mBuilder();
            director.BuildStudio(studioBuilder);
            studio = studioBuilder.GetStudio;
            PrintResult(studio, "24m");

            studioBuilder = new Studio26mBuilder();
            director.BuildStudio(studioBuilder);
            studio = studioBuilder.GetStudio;
            PrintResult(studio, "26m");

            studioBuilder = new Studio28mBuilder();
            director.BuildStudio(studioBuilder);
            studio = studioBuilder.GetStudio;
            PrintResult(studio, "28m");
        }

        private static void PrintResult(Studio studio, string name)
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"[+] - Studio {name}");
            Console.WriteLine($"Flooring type: {studio.FlooringType}");
            Console.WriteLine($"Financing type: {studio.FinancingType}");
            Console.WriteLine($"Studio value: {studio.Value.ToString("C")}");
        }
    }
}
