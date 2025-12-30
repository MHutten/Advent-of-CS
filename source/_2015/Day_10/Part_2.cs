using System;

using advent_of_code._2015.Day_10;

class Part_2 {

    static void Main(string[] args) {

        string input = args[0];

        for (int iteration = 0; iteration < 50; iteration++) {
            input = Elves_Look_Elves_Say.look_and_say(input);
        }

        Console.WriteLine(input.Length);

    }

}