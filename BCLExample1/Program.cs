using System;
using System.Numerics;
using System.Globalization;

namespace BCLExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter 1st number:");
            //double input1 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter 2nd number:");
            //double input2 = Double.Parse(Console.ReadLine());

            //BigInteger bigInteger1 = new BigInteger(input1);
            //BigInteger bigInteger2 = new BigInteger(input2);

            //Console.WriteLine("Addition of 2 Big Integers are: " + (bigInteger1 + bigInteger2));
            //Console.WriteLine("Subtraction of 2 Big Integers are: " + (bigInteger1 - bigInteger2));
            //Console.WriteLine("Multiplication of 2 Big Integers are: " + (bigInteger1 * bigInteger2));
            //Console.WriteLine("Division of 2 Big Integers are: " + (bigInteger1 / bigInteger2));
    

            //var valuetuple1 = (1, "someone", "John");
            //Console.WriteLine(valuetuple1.Item1);
            //Console.WriteLine(valuetuple1.Item2);
            //Console.WriteLine(valuetuple1.Item3);

            //ValueTuple<int, string, string> valuetuple2 = (1, "something", "john");
            //(int, string, string) valuetuple3 = (1, "someone", "john");
            //(int id, string firstname, string lastname) person = (1, "someone", "john");
            //Console.WriteLine(person.id);
            //Console.WriteLine(person.firstname);
            //Console.WriteLine(person.lastname);

            //var valuetuple4 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
            //(int id, string fname, string lname) = getValueTuple();
            //Console.WriteLine(id);
            //Console.WriteLine(fname);
            //Console.WriteLine(lname);

            var ukEn = new CultureInfo("en-GB");
            var usEn = new CultureInfo("en-US");
            var frFr = new CultureInfo("fr-FR");

            Console.WriteLine(usEn.DisplayName);
            Console.WriteLine(ukEn.DisplayName);
            Console.WriteLine(frFr.DisplayName);

            Console.WriteLine(usEn.Parent.DisplayName);
            Console.WriteLine(frFr.Parent.DisplayName);

            Console.WriteLine(usEn.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));
            Console.WriteLine(ukEn.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));
            Console.WriteLine(frFr.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));

            //BigIntegerSystem();
            //ComplexNumberSystem();
            //GuidExamples();
            //TupleExamples();
        }
        private static (int, string, string) getValueTuple()//same
        {
            return (1, "someone", "john");
        }
        private static ValueTuple<int, string, string> getValueTuple1()//same
        {
            return (1, "someone", "john");
        }
        private static void TupleExamples()
        {
            Tuple<int, double, string> tuple = new Tuple<int, double, string>(1, 5.3, "John");
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);

            var tuple2 = Tuple.Create(1, 1, "John");
            print(tuple2);

            var res = returnTuple();
            Console.WriteLine(res.Item1);
            Console.WriteLine(res.Item2);
            Console.WriteLine(res.Item3);

            var tuple3 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12));
            Console.WriteLine(tuple3.Item1);
            Console.WriteLine(tuple3.Item2);
            Console.WriteLine(tuple3.Item3);
            Console.WriteLine(tuple3.Item4);
            Console.WriteLine(tuple3.Item5);
            Console.WriteLine(tuple3.Item6);
            Console.WriteLine(tuple3.Item7);
            Console.WriteLine(tuple3.Rest.Item1.Item1);
            Console.WriteLine(tuple3.Rest.Item1.Item2);
            Console.WriteLine(tuple3.Rest.Item1.Item3);
        }

        private static void print(Tuple<int, int, string> tuple)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
        }

        private static Tuple<int, string, string> returnTuple()
        {
            return Tuple.Create(1, "something", "John");
        }
        private static Tuple<int, bool> doSomething(int a, int b)
        {
            if (a > b)
            {
                return Tuple.Create(a - b, true);
            }
            else
            {
                return Tuple.Create(a - b, false);
            }
        }

        private static void GuidExamples()
        {
            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();
            Console.WriteLine("Equality check " + (guid1 == guid2));

            var bytes = new Byte[16];
            var guid3 = new Guid(bytes);
            Console.WriteLine("Guid value for: " + guid3);
            Console.WriteLine("Guid value for guid.Empty: " + Guid.Empty);
            for (int i = 0; i < 10; i++)
            {
                var guid = Guid.NewGuid();
                Console.WriteLine("Guid value for " + (i + 1) + " iteration: " + guid);
            }
        }

        private static void BigIntegerSystem()
        {
            BigInteger bigInteger = new BigInteger(9999999.99999);
            Console.WriteLine(bigInteger);

            BigInteger bigInteger1 = new BigInteger(675787545435654);
            Console.WriteLine(bigInteger1);

            String str = "867564335674954";
            BigInteger bigInteger2 = BigInteger.Parse(str);
            Console.WriteLine("Value of string: " + bigInteger2);

            Console.WriteLine("Power of big integer is: " + BigInteger.Pow(bigInteger, 3));
        }

        private static void ComplexNumberSystem()
        {
            Complex complex = new Complex(12, 6);
            Console.WriteLine("1st Complex Number is: " + complex);

            Complex complex1 = new Complex(12.65, 6.95);
            Console.WriteLine("2nd Complex Number is: " + complex1);

            Console.WriteLine("Sum of two complex number: " + (complex + complex1));

            Complex complex2 = new Complex(-1, 0);
            Console.WriteLine("Sqrt of complex number " + (Complex.Sqrt(complex2)));

            Console.WriteLine("Complex number in string " + complex2.ToString());

            Console.WriteLine("Complex number in format: " + complex2.Real + " + " + complex2.Imaginary + "i");
        }
    }
}
