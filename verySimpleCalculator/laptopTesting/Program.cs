List<string> calculationTypes = new List<string>();
// Creating list items //
calculationTypes.Add("Exit"); // 0
calculationTypes.Add("Addition"); // 1
calculationTypes.Add("Subtraction"); // 2
calculationTypes.Add("Multiplication"); // 3
calculationTypes.Add(("Division")); // 4
////////////////////////

maincode();



bool maincode()
{
    while (true)
    {
        Console.WriteLine("Simple Calculator.");
        for (int i = 0; i < calculationTypes.Count; i++)
        {
            Console.WriteLine($"{i}. {calculationTypes[i]}");
        }
        
        Console.Write("Choose #: ");
        int userPick = Convert.ToInt32(Console.ReadLine());

        switch (userPick)
        {
            case 0 :
                Console.WriteLine("Goodbye!");
                return false;
            case 1:
                additionFunc();
                Thread.Sleep(2000);
                break;
            case 2:
                subtractionFunc();
                Thread.Sleep(2000);
                break;
            case 3:
                multiplicationFunc();
                Thread.Sleep(2000);
                break;
            case 4:
                divisionFunc();
                Thread.Sleep(2000);
                break;
        }
    }
    }


// functions //
void additionFunc()
{
    Console.WriteLine("/////////////////////////////////////////////////////");
     Console.Write("Enter First Number: ");
     int user1st = Convert.ToInt32(Console.ReadLine());
     
     Console.Write("Enter Second Number: ");
     int user2nd = Convert.ToInt32(Console.ReadLine());

     int solution = user1st + user2nd;
     
     Console.WriteLine($"Your answer is {solution}.");
     Console.WriteLine("/////////////////////////////////////////////////////");

}

void subtractionFunc()
{
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.Write("Enter First Number: ");
    int user1st = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Enter Second Number: ");
    int user2nd = Convert.ToInt32(Console.ReadLine());

    int solution = user1st - user2nd;
     
    Console.WriteLine($"Your answer is {solution}.");
    Console.WriteLine("/////////////////////////////////////////////////////");

}

void multiplicationFunc()
{
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.Write("Enter First Number: ");
    int user1st = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Second Number: ");
    int user2nd = Convert.ToInt32(Console.ReadLine());

    int solution = user1st * user2nd;

    Console.WriteLine($"Your answer is {solution}.");
    Console.WriteLine("/////////////////////////////////////////////////////");
}

void divisionFunc()
{
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.Write("Enter First Number: ");
    int user1st = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Second Number: ");
    int user2nd = Convert.ToInt32(Console.ReadLine());

    int solution = user1st / user2nd;

    Console.WriteLine($"Your answer is {solution}.");
    Console.WriteLine("/////////////////////////////////////////////////////");
}



