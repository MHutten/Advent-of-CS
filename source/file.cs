using System.IO;

namespace advent_of_code {

    public class file {

        public static string read(string file_path) {
            return File.ReadAllText(file_path);
        }

    }

}