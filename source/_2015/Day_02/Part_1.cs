using System;

using advent_of_code;
using advent_of_code._2015.Day_02;

class Part_1 {

    static void Main(string[] args) {

        int area_of_wrapping_paper = 0;

        foreach (string line in file.read_lines(args[0])) {

            string[] dimensions = line.Split('x');
            
            area_of_wrapping_paper += I_Was_Told_There_Would_Be_No_Math.calculate_area_of_wrapping_paper(
                Int32.Parse(dimensions[0]),
                Int32.Parse(dimensions[1]),
                Int32.Parse(dimensions[2])
            );

        }

        Console.WriteLine(area_of_wrapping_paper);

    }

}