using System;

using advent_of_code._2015.Day_08;
using advent_of_code.testing;

public class MatchsticksTest : TestSuite {
    
    [Test]
    public static void test__calculate_memory_length__good_weather__quote_quote() {
        asserts.assert_equal(Matchsticks.calculate_memory_length("\"\""), 0);
    }

    [Test]
    public static void test__calculate_memory_length__good_weather__quote_abc_quote() {
        asserts.assert_equal(Matchsticks.calculate_memory_length("\"abc\""), 3);
    }

    [Test]
    public static void test__calculate_memory_length__good_weather__quote_aaa_backslash_quote_aaa_quote() {
        asserts.assert_equal(Matchsticks.calculate_memory_length("\"aaa\\\"aaa\""), 7);
    }

    [Test]
    public static void test__calculate_memory_length__good_weather__quote_backslash_x27_quote() {
        asserts.assert_equal(Matchsticks.calculate_memory_length("\"\\x27\""), 1);
    }

    [Test]
    public static void test__calculate_encoded_length__good_weather__quote_quote() {
        asserts.assert_equal(Matchsticks.calculate_encoded_length("\"\""), 6);
    }

    [Test]
    public static void test__calculate_encoded_length__good_weather__quote_abc_quote() {
        asserts.assert_equal(Matchsticks.calculate_encoded_length("\"abc\""), 9);
    }

    [Test]
    public static void test__calculate_encoded_length__good_weather__quote_aaa_backslash_quote_aaa_quote() {
        asserts.assert_equal(Matchsticks.calculate_encoded_length("\"aaa\\\"aaa\""), 16);
    }

    [Test]
    public static void test__calculate_encoded_length__good_weather__quote_backslash_x27_quote() {
        asserts.assert_equal(Matchsticks.calculate_encoded_length("\"\\x27\""), 11);
    }

    static void Main(string[] args){
        new MatchsticksTest().run();
    }

}