using System.Collections;

namespace advent_of_code._2015.Day_03 {

    public class Perfectly_Spherical_Houses_in_a_Vacuum {

        private static void update_location(int[] location, char instruction) {

            if (instruction == '^') {
                location[1]++;
            } else if (instruction == 'v') {
                location[1]--;
            } else if (instruction == '>') {
                location[0]++;
            } else {
                location[0]--;
            }

        }

        private static bool location_visited_before(ArrayList visited_houses, int[] location) {

            foreach (int[] house_location in visited_houses) {

                if (house_location[0] == location[0] && house_location[1] == location[1]) {
                    return true;
                }

            }

            return false;

        }

        public static int calculate_number_of_visited_houses(string instructions) {

            ArrayList visited_houses = new ArrayList();
            int[] location = {0, 0};
            visited_houses.Add(location.Clone());
            
            foreach (char instruction in instructions) {

                update_location(location, instruction);

                if (!location_visited_before(visited_houses, location)) {
                    visited_houses.Add(location.Clone());
                }

            }

            return visited_houses.Count;

        }

        public static int calculate_number_of_visited_houses_with_robo_santa(string instructions) {

            ArrayList visited_houses = new ArrayList();
            int[] santas_current_location = {0, 0};
            int[] robo_current_location = {0, 0};
            visited_houses.Add(santas_current_location.Clone());
            bool it_is_santas_turn = true;

            foreach (char instruction in instructions) {

                if (it_is_santas_turn) {
                    
                    update_location(santas_current_location, instruction);

                    if (!location_visited_before(visited_houses, santas_current_location)) {
                        visited_houses.Add(santas_current_location.Clone());
                    }

                } else {

                    update_location(robo_current_location, instruction);

                    if (!location_visited_before(visited_houses, robo_current_location)) {
                        visited_houses.Add(robo_current_location.Clone());
                    }

                }

                it_is_santas_turn = !it_is_santas_turn;

            }

            return visited_houses.Count;

        }

    }

}