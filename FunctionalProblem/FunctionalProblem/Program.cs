﻿using FunctionalProblem;

Console.WriteLine("Welcome to Functional Programming Problem");
Console.WriteLine("Enter 1 for Flip coin");
Console.WriteLine("Enter 2 for leap year");
Console.WriteLine("Enter 3 for power of two");
Console.WriteLine("Enter 4 for Hormonic number");
Console.WriteLine("Enter 5 for Factors");
Console.WriteLine("Enter 6 for Quotient and Remainder");
Console.WriteLine("Enter 7 for Swap two numbers");
Console.WriteLine("Enter 8 for Even ot Odd");
Console.WriteLine("Enter 9 for Vowel or consonant");
Console.WriteLine("Enter 10 for Largest three numbers");


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
    case 5:
        FactorsProblem factorsProblem = new FactorsProblem();
        factorsProblem.Factors();
        break;
    case 6:
        QuotientRemainderProblem quotientRemainderProblem = new QuotientRemainderProblem();
        quotientRemainderProblem.QuotientAndRemainder();
        break;
    case 7:
        SwappingNumberProblem swappingNumberProblem = new SwappingNumberProblem();
        swappingNumberProblem.SwapTwoNumber();
        break;
    case 8:
        EvenorOddProblem evenorOddProblem = new EvenorOddProblem();
        evenorOddProblem.EvenOrOdd();
        break;
    case 9:
        VowelConsonantProblem vowelConsonantProblem = new VowelConsonantProblem();
        vowelConsonantProblem.CheckVowelOrConsonant();
        break;
    case 10:
        LargestNumberProblem largestNumberProblem = new LargestNumberProblem();
        largestNumberProblem.LargestNumbers();
        break;
}