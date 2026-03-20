using System;

using advent_of_code._2015.Day_05;
using advent_of_code.testing;

public class DoesntHeHaveInternElvesForThisTest : TestSuite {

    [Test]
    public static void test__is_nice__good_weather__ugknbfddgicrmopn() {
        asserts.assert_true(Doesnt_He_Have_Intern_Elves_For_This.is_nice("ugknbfddgicrmopn"));
    }

    [Test]
    public static void test__is_nice__good_weather__aaa() {
        asserts.assert_true(Doesnt_He_Have_Intern_Elves_For_This.is_nice("aaa"));
    }

    [Test]
    public static void test__is_nice__good_weather__jchzalrnumimnmhp() {
        asserts.assert_false(Doesnt_He_Have_Intern_Elves_For_This.is_nice("jchzalrnumimnmhp"));
    }

    [Test]
    public static void test__is_nice__good_weather__haegwjzuvuyypxyu() {
        asserts.assert_false(Doesnt_He_Have_Intern_Elves_For_This.is_nice("haegwjzuvuyypxyu"));
    }

    [Test]
    public static void test__is_nice__good_weather__dvszwmarrgswjxmb() {
        asserts.assert_false(Doesnt_He_Have_Intern_Elves_For_This.is_nice("dvszwmarrgswjxmb"));
    }

    [Test]
    public static void test__is_nice_now__good_weather__qjhvhtzxzqqjkmpb() {
        asserts.assert_true(Doesnt_He_Have_Intern_Elves_For_This.is_nice_now("qjhvhtzxzqqjkmpb"));
    }

    [Test]
    public static void test__is_nice_now__good_weather__xxyxx() {
        asserts.assert_true(Doesnt_He_Have_Intern_Elves_For_This.is_nice_now("xxyxx"));
    }

    [Test]
    public static void test__is_nice_now__good_weather__uurcxstgmygtbstg() {
        asserts.assert_false(Doesnt_He_Have_Intern_Elves_For_This.is_nice_now("uurcxstgmygtbstg"));
    }

    [Test]
    public static void test__is_nice_now__good_weather__ieodomkazucvgmuy() {
        asserts.assert_false(Doesnt_He_Have_Intern_Elves_For_This.is_nice_now("ieodomkazucvgmuy"));
    }

    static void Main(string[] args){
        new DoesntHeHaveInternElvesForThisTest().run();
    }

}