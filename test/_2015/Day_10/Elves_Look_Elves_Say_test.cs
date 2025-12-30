using System;

using advent_of_code._2015.Day_10;
using advent_of_code.testing;

public class ElvesLookElvesSayTest : TestSuite {
    
    [Test]
    public static void test__look_and_say__good_weather__1() {
        asserts.assert_equal(Elves_Look_Elves_Say.look_and_say("1"), "11");
    }

    [Test]
    public static void test__look_and_say__good_weather__11() {
        asserts.assert_equal(Elves_Look_Elves_Say.look_and_say("11"), "21");
    }

    [Test]
    public static void test__look_and_say__good_weather__21() {
        asserts.assert_equal(Elves_Look_Elves_Say.look_and_say("21"), "1211");
    }

    [Test]
    public static void test__look_and_say__good_weather__1211() {
        asserts.assert_equal(Elves_Look_Elves_Say.look_and_say("1211"), "111221");
    }

    [Test]
    public static void test__look_and_say__good_weather__111221() {
        asserts.assert_equal(Elves_Look_Elves_Say.look_and_say("111221"), "312211");
    }

    static void Main(string[] args){
        new ElvesLookElvesSayTest().run();
    }

}