using System;

namespace Guess_Game
{
    class MainClass
    {
        static int R = Random();

        
        public static void Main(string[] args)
        {


            // Console.WriteLine("Hello World!");
            Guess();
             
        }



        public static int Random()
        {
            Random create_Num = new Random();

            int Random_number = create_Num.Next(1, 11);
            return Random_number;
        }

        
        public static void Hint()
        {

            int x = R;
            //Console.Clear();
            Console.WriteLine("Press: \n1)To know whether Number is Even or Odd" +
                                    " \n2)To know the Range of Number. ");

            int hint_choice = Convert.ToInt32(Console.ReadLine());

            if (hint_choice == 1)
            {
                if (x % 2 == 0)
                {
                    //Console.Clear();
                    Console.WriteLine("The Number is Even.");
                    
                }
                else
                {
                    //Console.Clear();
                    Console.WriteLine("The Number is Odd.");
                }
                
            }
            else if (hint_choice == 2)
            {
                if (x <= 5)
                {

                    Console.WriteLine("The Number is in Range of 1 to 5.");

                }
                else if (x > 5)
                {
                    Console.WriteLine("The Number is in Range of 6 to 10.");

                }

            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }

        }


        public static void Guess()
        {
            int Random_number = R;

            Console.WriteLine("Welcome to the Mind Game :  "+Random_number);

            Console.WriteLine("Press Enter to Start Game.");
            string press = Console.ReadLine();
            Console.Clear();


            //Console.WriteLine(Random_number);
            bool incorrect = true;
            int tries = 3;
            
            while (incorrect)
            {
                tries -= 1;
                //Console.Clear();
                Console.Write("Enter Your Number  : ");
                int entry = Convert.ToInt32(Console.ReadLine());

                if (entry == Random_number)
                {
                    Console.Clear();
                    Console.WriteLine("You have won the Game.");
                    incorrect = false;
                }


                else if (entry != Random_number && tries > 0)
                {

                    Console.Clear();
                    Console.WriteLine("You Have Entered wrong Answer.\n Enter Again.....");

                    Console.WriteLine("Do You Need a Hint... Press 'Y' or any other key to Continue..");

                    char choice = Convert.ToChar(Console.ReadLine().ToUpper());
                    Console.Clear();
                    if (choice == 'Y')
                    {
                        Hint();

                    }

                }

                else if (entry != Random_number && tries == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You have Lost the Game" +
                        "Your Answer is not Correct");
                    incorrect = false;

                }

                
            }
            


        }


    }
}
