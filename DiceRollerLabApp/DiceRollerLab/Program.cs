// Dice Roller
using DiceRollerLab;

int Counter = 1;

Console.WriteLine("Welcome to the Grand Circus Casino");
Console.Write("How many sides should each side have?:  ");

string? NumberOfSides = Console.ReadLine();
bool ValidNumber = int.TryParse(NumberOfSides, out int ParsedInt);
if (!ValidNumber)
{
    Console.WriteLine("Please enter a valid Number: Please try again Later");
}
bool TryAgain = false;
do
{
    int FirstRandomNumber = DiceRollerMethods.GenerateRandomNumber(ParsedInt + 1);
    int SecondRandomNumber = DiceRollerMethods.GenerateRandomNumber(ParsedInt + 1);
    int Sum = FirstRandomNumber + SecondRandomNumber;
    Console.WriteLine($"Roll {Counter}: ");
    Console.WriteLine($"You rolled a {FirstRandomNumber} and a {SecondRandomNumber} ({Sum} total)");
    if (ParsedInt == 6) // When user inputs 6 as dice input
    {
        string ResultOfCombination = DiceRollerMethods.ReturnValidCombination(FirstRandomNumber, SecondRandomNumber);
        string ValidTotal = DiceRollerMethods.ReturnValidTotal(FirstRandomNumber, SecondRandomNumber);
        Console.WriteLine($"{ResultOfCombination}");
        Console.WriteLine($"{ValidTotal}");
    }

    else
    {
        string ResultOfCombination = DiceRollerMethods.ReturnValidCombinationForOthers(FirstRandomNumber, SecondRandomNumber);
        string ValidTotal = DiceRollerMethods.ReturnValidTotalForOthers(FirstRandomNumber, SecondRandomNumber);
        Console.WriteLine($"{ResultOfCombination}");
        Console.WriteLine($"{ValidTotal}");
    }
              


    Console.Write("Roll Again? (y/n):");
    string? RollAgain = Console.ReadLine();
    if (RollAgain != null && RollAgain.ToLower() == "y")
    {
        Counter = Counter + 1;
        TryAgain = true;
        Sum = 0;
    }
    else
    {
        Console.WriteLine("Thanks for Playing!!");
        TryAgain = false;
    }

}
while (TryAgain);