namespace PaletImporter
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ObjectId順に並べたシートをcsv化したものを使う
            string fileName = "Palet1.1.1.2_name_define.csv";

            string relativePath = Path.Combine("..", "..", "..", fileName);
            string filePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, relativePath));
            //Console.WriteLine(filePath);

            List<string> lines = File.ReadAllLines(filePath)
                .Select(line => 
                {
                    string[] words = line.Trim().Split(",").ToArray();
                    return $"{{ {words[0]}, \"{words[1]}\" }},";
                }).ToList();

            string directoryPath = Path.GetDirectoryName(filePath)!;
            string outputPath = Path.Combine(directoryPath, "output_name.txt");
            File.WriteAllLines(outputPath, lines);
            //Console.WriteLine(string.Join("\n",lines));
            ExtractColorCode();
        }

        public static void ExtractColorCode()
        {
            string fileName = "Palet1.1.1.2_color_define.csv";

            string relativePath = Path.Combine("..", "..", "..", fileName);
            string filePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, relativePath));

            //{ (326,Variation.Unpainted), new("599CBA") },
            List<string> lines = File.ReadAllLines(filePath)
                .Select(line =>
                {
                    string[] words = line.Trim().Split(",").ToArray();
                    return $"{{ ({words[0]},Variation.Unpainted), new(\"{words[2]}\") }},";
                }).ToList();

            string directoryPath = Path.GetDirectoryName(filePath)!;
            string outputPath = Path.Combine(directoryPath, "output_color.txt");
            File.WriteAllLines(outputPath, lines);
        }
    }
}