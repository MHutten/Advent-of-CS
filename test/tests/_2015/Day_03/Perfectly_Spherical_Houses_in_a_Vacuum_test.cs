using System;

using advent_of_code._2015.Day_03;
using advent_of_code.testing;

public class PerfectlySphericalHousesinaVacuumTest : TestSuite {

    [Test]
    public static void test__calculate_number_of_visited_houses__good_weather__east() {
        asserts.assert_equal(Perfectly_Spherical_Houses_in_a_Vacuum.calculate_number_of_visited_houses(">"), 2);
    }

    [Test]
    public static void test__calculate_number_of_visited_houses__good_weather__north_east_south_west() {
        asserts.assert_equal(Perfectly_Spherical_Houses_in_a_Vacuum.calculate_number_of_visited_houses("^>v<"), 4);
    }

    [Test]
    public static void test__calculate_number_of_visited_houses__good_weather__north_south_repeated_5_times() {
        asserts.assert_equal(Perfectly_Spherical_Houses_in_a_Vacuum.calculate_number_of_visited_houses("^v^v^v^v^v"), 2);
    }

    [Test]
    public static void test__calculate_number_of_visited_houses_with_robo_santa__good_weather__north_south() {
        asserts.assert_equal(Perfectly_Spherical_Houses_in_a_Vacuum.calculate_number_of_visited_houses_with_robo_santa("^v"), 3);
    }

    [Test]
    public static void test__calculate_number_of_visited_houses_with_robo_santa__good_weather__north_east_south_west() {
        asserts.assert_equal(Perfectly_Spherical_Houses_in_a_Vacuum.calculate_number_of_visited_houses_with_robo_santa("^>v<"), 3);
    }

    [Test]
    public static void test__calculate_number_of_visited_houses_with_robo_santa__good_weather__north_south_repeated_5_times() {
        asserts.assert_equal(Perfectly_Spherical_Houses_in_a_Vacuum.calculate_number_of_visited_houses_with_robo_santa("^v^v^v^v^v"), 11);
    }

    static void Main(string[] args){
        new PerfectlySphericalHousesinaVacuumTest().run();
    }

}