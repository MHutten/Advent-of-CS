using System;
using System.Linq;

namespace advent_of_code._2015.Day_06 {

    public class Operation {

        public string operation;
        public int[] start;
        public int[] end;

        public Operation(string operation, int[] start, int[] end) {

            this.operation = operation;
            this.start = start;
            this.end = end;

        }

    }

    public class Probably_a_Fire_Hazard {

        public static Operation parse_operation_string(string input) {

            string[] substrings = input.Split(' ');
            string operation;

            if (substrings[0].Equals("turn")) {

                operation = substrings[1];
                substrings = new ArraySegment<string>(substrings, 2, substrings.Length - 2).ToArray();

            } else {

                operation = substrings[0];
                substrings = new ArraySegment<string>(substrings, 1, substrings.Length - 1).ToArray();

            }

            string[] start = substrings[0].Split(',');
            string[] end = substrings[2].Split(',');

            return new Operation(
                operation,
                new int[]{
                    Int32.Parse(start[0]),
                    Int32.Parse(start[1])
                },
                new int[]{
                    Int32.Parse(end[0]),
                    Int32.Parse(end[1])
                }
            );

        }

    }

    public class Lights {

        private bool[,] lights;

        public Lights(bool initial_state) {

            this.lights = new bool[1000, 1000];

            for (int i = 0; i < this.lights.GetLength(0); i++) {

                for(int j = 0; j < this.lights.GetLength(1); j++) {
                    this.lights[i, j] = initial_state;
                }

            }

        }

        public void turn_on(int[] start, int[] end) {

            for (int i = start[0]; i < end[0] + 1; i++) {

                for (int j = start[1]; j < end[1] + 1; j++) {
                    this.lights[i, j] = true;
                }

            }

        }

        public void toggle(int[] start, int[] end) {

            for (int i = start[0]; i < end[0] + 1; i++) {

                for (int j = start[1]; j < end[1] + 1; j++) {
                    this.lights[i, j] = !this.lights[i, j];
                }

            }

        }

        public void turn_off(int[] start, int[] end) {

            for (int i = start[0]; i < end[0] + 1; i++) {

                for (int j = start[1]; j < end[1] + 1; j++) {
                    this.lights[i, j] = false;
                }

            }

        }

        public int get_number_of_lit_lights() {

            int number_of_lit_lights = 0;

            for (int i = 0; i < this.lights.GetLength(0); i++) {

                for (int j = 0; j < this.lights.GetLength(1); j++) {
                    
                    if (this.lights[i, j]) {
                        number_of_lit_lights++;
                    }

                }

            }

            return number_of_lit_lights;

        }

        public bool get_light_state(int i, int j) {
            return this.lights[i, j];
        }

        public void set_light_state(int i, int j, bool value) {
            this.lights[i, j] = value;
        }

    }

    public class LightsWithBrightnessControls {

        private int[,] lights;

        public LightsWithBrightnessControls(int initial_state) {

            this.lights = new int[1000, 1000];

            for (int i = 0; i < this.lights.GetLength(0); i++) {

                for(int j = 0; j < this.lights.GetLength(1); j++) {
                    this.lights[i, j] = initial_state;
                }

            }

        }

        public void turn_on_ancient_nordic_elvish(int[] start, int[] end) {

            for (int i = start[0]; i < end[0] + 1; i++) {

                for (int j = start[1]; j < end[1] + 1; j++) {
                    this.lights[i, j]++;
                }

            }

        }

        public void toggle_ancient_nordic_elvish(int[] start, int[] end) {

            for (int i = start[0]; i < end[0] + 1; i++) {

                for (int j = start[1]; j < end[1] + 1; j++) {
                    this.lights[i, j] += 2;
                }

            }

        }

        public void turn_off_ancient_nordic_elvish(int[] start, int[] end) {

            for (int i = start[0]; i < end[0] + 1; i++) {

                for (int j = start[1]; j < end[1] + 1; j++) {

                    if (this.lights[i, j] > 0) {
                        this.lights[i, j]--;
                    }
                    
                }

            }

        }

        public int calculate_total_brightness() {

            int brightness = 0;

            for (int i = 0; i < this.lights.GetLength(0); i++) {

                for (int j = 0; j < this.lights.GetLength(1); j++) {
                    brightness += this.lights[i, j];
                }

            }

            return brightness;

        }

        public int get_light_brightness(int i, int j) {
            return this.lights[i, j];
        }

        public void set_light_brightness(int i, int j, int value) {
            this.lights[i, j] = value;
        }

    }

}