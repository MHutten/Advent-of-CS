using System;

using advent_of_code;
using advent_of_code._2015.Day_08;

class Part_2 {

    static void Main(string[] args) {

        int difference = 0;

        foreach (string line in file.read_lines(args[0])) {
            difference += Matchsticks.calculate_encoded_length(line) - line.Length;
        }

        Console.WriteLine(difference);

    }

}