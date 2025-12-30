using System;

namespace advent_of_code._2015.Day_10 {

    public class Elves_Look_Elves_Say {

        public static string look_and_say(string input) {

            string output = "";
            int string_index = 0;

            while (string_index < input.Length) {

                if (!Char.IsDigit(input[string_index])) {
                    throw new Exception("'" + input[string_index] + "' is not a digit\n");
                }

                char digit = input[string_index];
                int count = 1;

                while (string_index + count < input.Length && input[string_index + count] == digit) {
                    count++;
                }

                output += count.ToString() + digit;
                string_index += count;

            }

            return output;

        }

    }

}