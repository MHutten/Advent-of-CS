using System;

using advent_of_code._2015.Day_02;
using advent_of_code.testing;

public class IWasToldThereWouldBeNoMathTest : TestSuite {

    [Test]
    public static void test__calculate_area_of_wrapping_paper__good_weather__2x3x4() {
        asserts.assert_equal(I_Was_Told_There_Would_Be_No_Math.calculate_area_of_wrapping_paper(2, 3, 4), 58);
    }

    [Test]
    public static void test__calculate_area_of_wrapping_paper__good_weather__1x1x10() {
        asserts.assert_equal(I_Was_Told_There_Would_Be_No_Math.calculate_area_of_wrapping_paper(1, 1, 10), 43);
    }

    [Test]
    public static void test__calculate_ribbon_length__good_weather__2x3x4() {
        asserts.assert_equal(I_Was_Told_There_Would_Be_No_Math.calculate_ribbon_length(2, 3, 4), 34);
    }

    [Test]
    public static void test__calculate_ribbon_length__good_weather__1x1x10() {
        asserts.assert_equal(I_Was_Told_There_Would_Be_No_Math.calculate_ribbon_length(1, 1, 10), 14);
    }

    static void Main(string[] args){
        new IWasToldThereWouldBeNoMathTest().run();
    }

}