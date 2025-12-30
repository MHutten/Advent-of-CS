using advent_of_code.testing;

namespace advent_of_code.testing {

    public class asserts {

        public static void assert_true(bool boolean) {

            if (!boolean) {
                throw new TestFailure(boolean + " is false");
            }

        }

        public static void assert_false(bool boolean) {

            if (boolean) {
                throw new TestFailure(boolean + " is true");
            }

        }

        public static void assert_equal(int first, int second) {

            if (first != second) {
                throw new TestFailure(first + " != " + second);
            }

        }

    }

}