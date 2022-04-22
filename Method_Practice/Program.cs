using System;

namespace Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(UserStory());



            int theResult = Add();
            Console.WriteLine($"{theResult}\n");

            int theResult2 = Subtract();
            Console.WriteLine($"{theResult2}\n");

            int theResult3 = Multiplication();
            Console.WriteLine($"{theResult3}\n");

            int theResult4 = Divide();
            Console.WriteLine($"{theResult4}\n");

        }

        public static String UserStory()
        {

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("What's your favorite color?: ");
            string favColor = Console.ReadLine();

            Console.Write("What's your favorite animal?: ");
            string favAnimal = Console.ReadLine();

            Console.Write("What's your favorite genere of msuic?: ");
            string favMusic = Console.ReadLine();

            Console.Write("What are you scared of? : ");
            string fear = Console.ReadLine();

            string myStory = ($"\nYour name is {name} and your favorite color is {favColor}.\nYou also like {favAnimal}, {favMusic}, and is scared of {fear}!");

            return myStory;

        }

        public static int Add()

        {
            Console.WriteLine("Enter any two numbers for Addition");
            int uNum1 = int.Parse(Console.ReadLine());
            int uNum2 = int.Parse(Console.ReadLine());
            int theCalculation = uNum1 +  uNum2;
          
            return theCalculation;
        }


        public static int Subtract()

        {
            Console.WriteLine("Enter any two numbers for Subtraction");
            int uNum1 = int.Parse(Console.ReadLine());
            int uNum2 = int.Parse(Console.ReadLine());
            int theCalculation = uNum1 - uNum2;

            return theCalculation;
        }


        public static int Multiplication()

        {
            Console.WriteLine("Enter any two numbers for Mutiplication");
            int uNum1 = int.Parse(Console.ReadLine());
            int uNum2 = int.Parse(Console.ReadLine());
            int theCalculation = uNum1 * uNum2;

            return theCalculation;
        }


        public static int Divide()

        {
            Console.WriteLine("Enter any two numbers for Division");
            int uNum1 = int.Parse(Console.ReadLine());
            int uNum2 = int.Parse(Console.ReadLine());
            int theCalculation = uNum1 / uNum2;

            return theCalculation;
        }

    }

}


