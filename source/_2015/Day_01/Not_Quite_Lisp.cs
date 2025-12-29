using System.IO;

namespace advent_of_code._2015.Day_01 {

    public class Not_Quite_Lisp {

        public static int calculate_santas_final_destination(string directions) {

            int floor = 0;

            foreach (char direction in directions) {

                if (direction == '(') {
                    floor++;
                } else {
                    floor--;
                }

            }
            
            return floor;

        }

        public static int calculate_basement_entering_instruction_position(string directions) {

            int floor = 0;

            for (int index = 0; index < directions.Length; index++) {

                if (directions[index] == '(') {
                    floor++;
                } else {
                    floor--;
                }

                if (floor < 0) {
                    return index + 1;
                }

            }

            return -1;

        }

    }

}