using System;

using advent_of_code;
using advent_of_code._2015.Day_05;

class Part_2 {

    static void Main(string[] args) {

        int number_of_nice_strings = 0;

        foreach (string line in file.read_lines(args[0])) {

            if (Doesnt_He_Have_Intern_Elves_For_This.is_nice_now(line)) {
                number_of_nice_strings++;
            }
            
        }

        Console.WriteLine(number_of_nice_strings);

    }

}