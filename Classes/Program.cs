using System;

//ref link:https://www.youtube.com/watch?v=aRHXInSdK6g&list=PLF932FF551E0ADD16&index=10
// for loop - rearrange while loop
// C# - called methods
// Java - called methods.
// C++ - called functions

// classes - a way to stores multiple values together in a single value
// class - a blueprint for several objects

class Person    // class with 4 primitive types
{
    public string FirstName;
    public string MiddleName;
    public string LastName;
    public int Age;
}

//class Tuple   // class with 2 primitive types
//{
//    public int FirstValue;
//    public int SecondValue;
//}

class MyClass
{






    ////static int Square(int value)    // return type: int
    //static float Square(float value)    // return type: float
    //{
    //    return value * value;
    //    //float returnValue = value * value;
    //    //return returnValue;
    //
    //}





    //static void SayHello(string myName, string yourName)    // parameters
    //{
    //    Console.WriteLine("Hello, " + yourName + ", my name is " + myName + ".");
    //}   // OUTPUT: Hello, Eric, my name is Kulpot.
    //    //         Hello, Bob, my name is Rebeccar.






    //static void AMethod()
    //{
    //    Console.WriteLine("this is the first line in the method");
    //    Console.WriteLine("this is the second line in the method");
    //    Console.WriteLine("this is the third line in the method");
    //}

    static void Main()  // Main is important - all program starts in main
    {
        Person myTeacher = new Person   // myTeacher - object
        {
            FirstName = "Kulpot",
            LastName = "Wahu",
            MiddleName = "Neumont University",
            Age = 55
        };
        Person aStudent = new Person    // aStudent - another object
        {
            FirstName = "Chris",
            LastName = "Bob",
        };
        Console.WriteLine(myTeacher.FirstName);
        Console.WriteLine(myTeacher.Age);

        //int i = 5; // primitive - lowest form of a type that can be declare
        //int i = { 5, 11 }; // cant give to values to "int" requires nonprimitive
        //Tuple myTuple = new Tuple 
        //{ 
        //    FirstValue  = 5,
        //    SecondValue = 11
        //};
        //Console.WriteLine(myTuple.FirstValue);
        //Console.WriteLine(myTuple.SecondValue);






        //float someFloatValue = 2342.323f;
        //float fiveSquared = Square(5);
        //Console.WriteLine(fiveSquared); // output: 25




        //SayHello("Kulpot", "Eric");     //Arguments
        //SayHello("Rebeccar", "Bob");






        //Console.WriteLine("Kulpot");
        //AMethod(); // calling a method
        //Console.WriteLine("Wahu");
        //AMethod();
        //Console.WriteLine("Coach");
        /*-----OUTPUT-----
         * 
            Kulpot
            this is the first line in the method
            this is the second line in the method
            this is the third line in the method
            Wahu
            this is the first line in the method
            this is the second line in the method
            this is the third line in the method
            Coach
         * 
         */




        //int i = 1;
        //while (i <= 20)
        //{
        //    Console.WriteLine(i);
        //    i = i + 1;
        //}
        //Console.WriteLine("Done"); // output 1 to 20 Done

        //for (int i = 1; i <= 20; i = i + 1)
        //for (int i = 1; i <= 20; i++)   // i = i + 1 same as i++
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("Done");   // output 1 to 20 Done
    }
}