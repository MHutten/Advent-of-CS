using System;

using advent_of_code;
using advent_of_code._2015.Day_06;

class Part_2 {

    static void Main(string[] args) {

        LightsWithBrightnessControls lights = new LightsWithBrightnessControls(0);

        foreach (string line in file.read_lines(args[0])) {

            Operation operation = Probably_a_Fire_Hazard.parse_operation_string(line);

            if (operation.operation.Equals("on")) {
                lights.turn_on_ancient_nordic_elvish(operation.start, operation.end);
            } else if (operation.operation.Equals("toggle")) {
                lights.toggle_ancient_nordic_elvish(operation.start, operation.end);
            } else {
                lights.turn_off_ancient_nordic_elvish(operation.start, operation.end);
            }
            
        }

        Console.WriteLine(lights.calculate_total_brightness());

    }

}