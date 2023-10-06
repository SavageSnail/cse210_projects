using System;

List<int> numbers = new List<int>();

int userNumber = -1;
while (userNumber != 0)
{
    Console.Write("Enter a number, type 0 when finished: ");

    string userResponse = Console.ReadLine();
    userNumber = int.Parse(userResponse);

    if (userNumber != 0)
    {
        numbers.Add(userNumber);
    }
}

//Part 1

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine($"Sum: {sum}");
/*
         Part 2
        I'll admit, I had to look at the sample solution to figure this one out
        I didn't even consider using floats
*/
float average = ((float)sum) / numbers.Count;
Console.WriteLine($"Average: {average}");

//

int max = numbers[0];

foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}

Console.WriteLine($"Max: {max}");

/*
List<string> words = new List<string>();

words.Add("phone");
words.Add("keyboard");
words.Add("mouse");

Console.WriteLine(words.Count);

for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}
 
*/
