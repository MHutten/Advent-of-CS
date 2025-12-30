using System;

using advent_of_code;
using advent_of_code._2015.Day_02;

class Part_2 {

    static void Main(string[] args) {

        int ribbon_length = 0;

        foreach (string line in file.read_lines(args[0])) {

            string[] dimensions = line.Split('x');
            
            ribbon_length += I_Was_Told_There_Would_Be_No_Math.calculate_ribbon_length(
                Int32.Parse(dimensions[0]),
                Int32.Parse(dimensions[1]),
                Int32.Parse(dimensions[2])
            );

        }

        Console.WriteLine(ribbon_length);

    }

}