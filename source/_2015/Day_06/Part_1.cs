using System;

using advent_of_code;
using advent_of_code._2015.Day_06;

class Part_1 {

    static void Main(string[] args) {

        Lights lights = new Lights(false);

        foreach (string line in file.read_lines(args[0])) {

            Operation operation = Probably_a_Fire_Hazard.parse_operation_string(line);

            if (operation.operation.Equals("on")) {
                lights.turn_on(operation.start, operation.end);
            } else if (operation.operation.Equals("toggle")) {
                lights.toggle(operation.start, operation.end);
            } else {
                lights.turn_off(operation.start, operation.end);
            }
            
        }

        Console.WriteLine(lights.get_number_of_lit_lights());

    }

}