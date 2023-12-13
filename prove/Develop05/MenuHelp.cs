class NewGoal
{
    public Goal MakeGoal()
    {
        Console.WriteLine("1. Simple \n2. Eternal \n3. Checklist");
        Console.Write("What kind of Goal would you like to make?: ");
        int goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice == 1)
        {
            Console.Write("Name of Goal: ");
            string name = Console.ReadLine();
            Console.Write("\nShort description of goal: ");
            string description = Console.ReadLine();
            Console.Write("\nPoints for achieving goal: ");
            int point = int.Parse(Console.ReadLine());
            return new SimpleGoal(name, description, point, false);
        }

        else if (goalChoice == 2)
        {
            Console.Write("Name of Goal: ");
            string name = Console.ReadLine();
            Console.Write("\nShort description of goal: ");
            string description = Console.ReadLine();
            Console.Write("\nPoints for achieving goal: ");
            int point = int.Parse(Console.ReadLine());
            return new EternalGoal(name, description, point);
        }

        else
        {
            Console.Write("Name of Goal: ");
            string name = Console.ReadLine();
            Console.Write("\nShort description of goal: ");
            string description = Console.ReadLine();
            Console.Write("\nHow many times would you like to accomplish this?: ");
            int limit = int.Parse(Console.ReadLine());
            Console.Write("\nPoints for making progress: ");
            int point = int.Parse(Console.ReadLine());
            Console.Write("\nPoints for completing goal: ");
            int bonus = int.Parse(Console.ReadLine());
            return new CheckListG(name, description, point, 0, bonus, limit);
        }
    }
}