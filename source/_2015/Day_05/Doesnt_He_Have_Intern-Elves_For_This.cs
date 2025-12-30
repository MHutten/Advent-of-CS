namespace advent_of_code._2015.Day_05 {

    public class Doesnt_He_Have_Intern_Elves_For_This {

        private static bool is_vowel(char character) {

            string vowels = "aeiou";

            foreach (char vowel in vowels) {

                if (character == vowel) {
                    return true;
                }

            }

            return false;

        }

        private static bool is_naughty_substring(string substring) {

            string[] naughty_substrings = {"ab", "cd", "pq", "xy"};

            foreach (string naughty_substring in naughty_substrings) {

                if (substring.Equals(naughty_substring)) {
                    return true;
                }

            }

            return false;

        }

        private static bool occurs_at_least_twice(string sub, string sup, int start) {

            for (int sup_index = start; sup_index < sup.Length - 1; sup_index++) {

                bool is_match = true;

                for (int sub_index = 0; sub_index < sub.Length; sub_index++) {

                    if (sub[sub_index] != sup[sup_index + sub_index]) {
                        is_match = false;
                    }

                }

                if (is_match) {
                    return true;
                }

            }

            return false;

        }

        public static bool is_nice(string input) {
        
            bool contains_consecutives = false;
            int vowel_count = 0;

            if (is_vowel(input[0])) {
                vowel_count++;
            }

            for (int index = 1; index < input.Length; index++) {

                if (is_naughty_substring(input.Substring(index-1, 2))) {
                    return false;
                }

                if (is_vowel(input[index])) {
                    vowel_count++;
                }

                if (input[index - 1] == input[index]) {
                    contains_consecutives = true;
                }

            }

            return contains_consecutives && (vowel_count > 2);

        }

        public static bool is_nice_now(string input) {

            bool contains_multiple_non_overlapping_duplicate_pairs = false;
            bool contains_repeating_character_seperated_by_one_character = false;

            if (occurs_at_least_twice(input.Substring(0, 2), input, 2)) {
                contains_multiple_non_overlapping_duplicate_pairs = true;
            }

            for (int index = 2; index < input.Length; index++) {

                if (occurs_at_least_twice(input.Substring(index - 1, 2), input, index + 1)) {
                    contains_multiple_non_overlapping_duplicate_pairs = true;
                }

                if (input[index - 2] == input[index]) {
                    contains_repeating_character_seperated_by_one_character = true;
                }

                if (contains_multiple_non_overlapping_duplicate_pairs && contains_repeating_character_seperated_by_one_character) {
                    return true;
                }

            }

            return false;

        }

    }

}