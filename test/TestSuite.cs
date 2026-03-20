using System;
using System.Reflection;

namespace advent_of_code.testing {

    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class Test : Attribute {}

    [Serializable]
    public class TestFailure : Exception {

        public TestFailure () {}

        public TestFailure (string message) : base(message) {}

        public TestFailure (string message, Exception innerException) : base (message, innerException) {}

    }

    public class TestSuite {

        private bool is_test(MethodInfo method) {

            foreach (Object attribute in method.GetCustomAttributes()) {
                
                if (attribute.GetType() == typeof(Test)) {
                    return true;
                }

            }

            return false;

        }

        protected void run() {

            foreach (MethodInfo method in this.GetType().GetMethods()) {

                if (!is_test(method)) {
                    continue;
                }

                try {
                    method.Invoke(this, null);
                    Console.WriteLine(method.Name + ": PASS");
                } catch (Exception exception) {
                    Console.WriteLine(method.Name + ": FAIL");
                }

            }

        }

    }

}