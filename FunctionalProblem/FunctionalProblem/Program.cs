using FunctionalProblem;

Console.WriteLine("Welcome to Functional Programming Problem");
Console.WriteLine("Enter 1 for Flip coin");
Console.WriteLine("Enter 2 for leap year");
Console.WriteLine("Enter 3 for power of two");
Console.WriteLine("Enter 4 for Hormonic number");


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

    case 3:
        PowerOfTwoProblem powerOfTwoProblem = new PowerOfTwoProblem();
        powerOfTwoProblem.PowerOfTwo();
        break;
    case 4:
        HarmonicProblem harmonicProblem = new HarmonicProblem();
        harmonicProblem.HarmonicNumber();
        break;
}