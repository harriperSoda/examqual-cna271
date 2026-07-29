//Creation of arrays for relevant things, namely the tests, the weightings and the weightedaverage set to 0. This will be used for the loop

string[] assesements = { "Test 1", "Test 2", "Assignment 1", "Project" };
double[] weightings = { 0.30, 0.50, 0.10, 0.10 };
double totalWeightedAverage = 0;

//Building of the loop that will itterate through the assesements 

for (int i = 0; i < assesements.Length; i++)
{
    while (true) //Loop to re-loop current assesement if input is invalid
    {
        Console.Write($"Enter mark for {assesements[i]}: ");
        string input = Console.ReadLine();

        //Validation beings

        //first check if numeric, then proceed to other checks, If not numeric we prompt error message
        if (double.TryParse(input, out double mark))
        {
            //Checks if below 0 or abov 100
            if (mark >= 0 && mark <= 100)
            {
                totalWeightedAverage += mark * weightings[i];
                break; //break out loop to move to next assesement
            }
            else
            {
                Console.WriteLine("Number/mark must be above 0 and less than 100");
            }
        }
        else
        {
            Console.WriteLine("You have entered a non-numeric number or not entered anything. Please review and try again");
        }
    }
}
//Logic to determine is student qualifies
Console.WriteLine($"Final average is {totalWeightedAverage} ");
if (totalWeightedAverage >= 50)
{
    Console.WriteLine("You qualify for the exam");
}
else
{
    Console.WriteLine("You do not qualify for the exam");
}