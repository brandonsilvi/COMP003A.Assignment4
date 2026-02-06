using System;

namespace COMP003A.Assignment4
{ 
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true; //loop to keep program running until user exit
            bool routineStop = false; //prevents routine from continuing after a safety stop 
            
            int stepCount = 0; //track # of completed steps
            int maxSteps = 5; //max # of steps the routine will allow
            int restrictedStep = 3; //step # to be skipped
            int safetyLimit = 4; // safely stops the routine early 
            //------------------------------------------------------
            while (runProgram) //loop to repeat the menu and provide options to user. Allows them to repeatedly
                               //view the menu as they execute the program to select their different options
            {
                Console.WriteLine("\n1. Start/Continue routine");
                Console.WriteLine("2. View Progress");
                Console.WriteLine("3. Exit");
                Console.Write("Enter option 1-3:   ");

                int option = int.Parse(Console.ReadLine()); //read user input

                if (option == 1)
                {
                    if (routineStop) //notification that routine has been stopped via the safety
                    {
                        Console.WriteLine("Routine has already been stopped by safety limit.");
                        continue;
                    }
                    
                    if (stepCount >= safetyLimit) //stops routine @ safety limit then prints the message and returns to menu
                    {
                        Console.WriteLine("Safety limit reached, routine stopped");
                        routineStop = true; /* safety limits such as this prevent further action towards the step count
                        This would be very useful when you has a set limitation that when reached must stop to prevent 
                        damage such as a the range of motion for robotics equipment */
                        continue;
                    }

                    if (stepCount >= maxSteps) //stops the routine when max steps are reached and returns to menu
                    {
                        Console.WriteLine("Routine Complete");
                        continue;
                    }

                    stepCount++; // adv the routine 1 step

                    if (stepCount == restrictedStep) // skip restricted step
                    {
                        Console.WriteLine("Step " + stepCount + " is restricted and skipped");
                        stepCount++;
                    }

                    Console.WriteLine("Routine step " + stepCount + " completed");
                }
                else if (option == 2) // view progress selection
                {
                    Console.WriteLine("Current steps completed: " + stepCount);
                }
                else if (option == 3) //end program 
                {
                    Console.WriteLine("Program ended");
                    break;
                }



            }
        }
    }
}
    