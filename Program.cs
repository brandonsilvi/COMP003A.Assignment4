using System;

namespace COMP003A.Assignment4
{
    
}

class Program
{
    static void main(string[] args)
    {
        bool runProgram = true; //loop to keep program running until user exit
        int stepCount = 0; //track # of completed steps
        int maxSteps = 5; //max # of steps the routine will allow
        int restrictedStep = 3; //step # to be skipped
        int safetyLimit = 4; // safely stops the routine early 
        //------------------------------------------------------
        while (runProgram) //loop to repeat the menu and provide options to user
        {
            Console.WriteLine("\n1.Start/Continue routine");
            Console.WriteLine("2. View Progress");
            Console.WriteLine("3. Exit");
            Console.Write("Enter option 1-3");

            int option = int.Parse(Console.ReadLine()); //read user input

            if (option == 1)
            {
                if (stepCount >= safetyLimit) //stops routine @ safety limit then prints the message and returns to menu
                {
                    Console.WriteLine("Safety limit reached, routine stopped");
                    continue;
                }

                if (stepCount >= maxSteps) //stops the routine when max steps are reached and returns to menu
                {
                    Console.WriteLine("Routine Complete");
                    continue;
                }

                stepCount++; //adv the routine 1 step

                
        


    }
}