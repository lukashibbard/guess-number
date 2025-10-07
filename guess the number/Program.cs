// See https://aka.ms/new-console-template for more information
bool numberguessed = false;
Random random = new Random();
int rannum = random.Next(1, 11);
do
{
    Console.WriteLine("this is the number guessing game, take your time and guess differnt numbers from 1-10 when you get it right you win");
    Console.Write("type your guess here:");
    int numberguess = Convert.ToInt32(Console.ReadLine());
    if (numberguess > rannum)
    {
        Console.WriteLine("not correct too high try again");
    }
    if (numberguess < rannum)
    {
        Console.WriteLine("not correct too low try again");
    }
    if (numberguess == rannum)
    {
        numberguessed = true;
    }

    numberguessed = true;
} while (numberguessed == false);
Console.WriteLine("you won yay!");