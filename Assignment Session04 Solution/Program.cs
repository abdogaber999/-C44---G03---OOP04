namespace Assignment_Session04_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Q1- Write a class named Calculator that contains a method named Add. Overload the Add method to:. Accept two integers and return their sum. . Accept three integers and return their sum. .Accept two doubles and return their sum.

            Calculator calc = new Calculator();

            Console.WriteLine("Sum of two integers: " + calc.Add(5, 10));
            Console.WriteLine("Sum of three integers: " + calc.Add(6, 11, 15));
            Console.WriteLine("Sum of two double: " + calc.Add(7.5, 12.5));

            #endregion

            #region Q2- Create a class named Rectangle with the following constructors: . A parameterless constructor that sets the width and height to 0.. A constructor that accepts width and height as integers.. A constructor that accepts a single integer and sets both width and height to that value.

            Rectangle r1 = new Rectangle();
            Console.WriteLine($"Rectangle 1: Width = {r1.Width}, Height = {r1.Height}");

            Rectangle r2 = new Rectangle(5, 10);
            Console.WriteLine($"Rectangle 2: Width = {r2.Width}, Height = {r2.Height}");

            Rectangle r3 = new Rectangle(8);
            Console.WriteLine($"Rectangle 2: Width = {r3.Width}, Height = {r3.Height}");

            #endregion

            #region Q3- Define a class Complex Number that represents a complex number with real and imaginary parts. *Note: Overload the +, - operator to add and subtract two complex numbers.

            ComplexNumber c1 = new ComplexNumber(6, 12);
            ComplexNumber c2 = new ComplexNumber(5, 10);

            ComplexNumber sum = c1 + c2;
            ComplexNumber difference = c1 - c2;

            Console.WriteLine($"firs complex number : {c1}");
            Console.WriteLine($"second complex number : {c2}");
            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Difference : {difference}");

            #endregion

            #region Q4- a) Create a base class named Employee with method That Works as it prints    "Employee is  working".

            Employee emp = new Employee();
            emp.Work();

            #endregion

            #region Q4 - b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 

            Manager mgr = new Manager();
            mgr.Work();

            #endregion

            #region Q5- a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".

            BaseClass baseobj = new BaseClass();
            baseobj.DisplayMessage();

            #endregion

            #region Q5- b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.

            DerivedClass1 derivedObj = new DerivedClass1();
            derivedObj.DisplayMessage();


            #endregion

            #region Q5- C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
            DerivedClass2 derived2 = new DerivedClass2();
            derived2.DisplayMessage();

            /// Explain the difference
            ///override: dynamic binding → بيربط حسب نوع الأوبجكت الفعلي وقت التشغيل.
            ///new: static binding → بيربط حسب نوع الريفرنس وقت الكومبايل.

            #endregion




            #endregion


            #region Part02

            #region Q1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

            Duration d1 = new Duration(5, 30, 50);
            d1.Display();

            #endregion

            #region Q2- Override All Systems. Object Members [To String(), Equals(),GetHashCode() ] .
            Duration d1 = new Duration(1, 30, 35);
            Duration d2 = new Duration(2, 40, 45);
            Duration d3 = new Duration(1, 30, 35);

            Console.WriteLine(d1.ToString());
            Console.WriteLine(d1.Equals(d2)); // False
            Console.WriteLine(d1.Equals(d3)); // True
            Console.WriteLine(d1.GetHashCode());

            #endregion

            #region Q3- Define All Required Constructors to Produce this output: -Duration D1 = new Duration(1, 10, 15); -D1.ToString();

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            #endregion

            #region Q4- Implement All required Operators overloading to enable this Code:

            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(3600);   // 1h 0m 0s
            Duration D3;

            D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D2;
            Console.WriteLine(D3);

            D3 = ++D1;   // يزود دقيقة
            Console.WriteLine(D3);

            D3 = --D2;   // يقلل دقيقة
            Console.WriteLine(D3);

            D1 = D1 - D2;
            Console.WriteLine(D1);

            if (D1 > D2)
                Console.WriteLine("D1 > D2");

            if (D1 <= D2)
                Console.WriteLine("D1 <= D2");

            if (D1)  
                Console.WriteLine("D1 Not Equal zero");

            DateTime obj = (DateTime)D1;
            Console.WriteLine(obj);

            #endregion

            #endregion
















        }
    }
}
