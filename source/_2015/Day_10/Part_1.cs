using System;

using advent_of_code._2015.Day_10;

class Part_1 {

    static void Main(string[] args) {

        string input = args[0];

        for (int iteration = 0; iteration < 40; iteration++) {
            input = Elves_Look_Elves_Say.look_and_say(input);
        }

        Console.WriteLine(input.Length);

    }

}