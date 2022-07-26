using FunctionalProblem;

Console.WriteLine("Welcome to Functional Programming Problem");
Console.WriteLine("Enter 1 for Flip coin");
Console.WriteLine("Enter 2 for leap year");


int Problem = Convert.ToInt32(Console.ReadLine());
switch (Problem)
{
    case 1:
        FlipCoin flipCoin = new FlipCoin();
        flipCoin.Flip_Percentage();
        break;
    case 2:
        LeapYearProblem leapYearProblem = new LeapYearProblem();
        leapYearProblem.LeapYear();
        break;

}