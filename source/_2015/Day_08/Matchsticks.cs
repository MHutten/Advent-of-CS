using System;

namespace advent_of_code._2015.Day_08 {

    public class Matchsticks {

        public static int calculate_memory_length(string source) {

            int length = 0;
            int index = 1;
            
            while (index < source.Length - 1) {

                if (source[index] != '\\') {
                    index++;
                } else if (source[index + 1] == '\\' || source[index + 1] == '\"') {
                    index += 2;
                } else if (source[index + 1] == 'x' && Uri.IsHexDigit(source[index + 2]) && Uri.IsHexDigit(source[index + 3])) {
                    index += 4;
                } else {
                    throw new Exception("Unexpected next characters '" + source[index + 1] + "', '" + source[index + 2] + "', and '" + source[index + 3] + "' in string \"" + source + "\"");
                }

                length++;

            }

            return length;

        }

        public static int calculate_encoded_length(string source) {

            int length = 2;

            foreach (char character in source) {

                if (character == '\"' || character == '\\') {
                    length += 2;
                } else {
                    length++;
                }

            }

            return length;

        }

    }

}