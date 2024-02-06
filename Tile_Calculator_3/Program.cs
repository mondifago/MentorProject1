namespace Tile_Calculator_3;

using System;


class Tile_Calculator_3
{
    static void Main(string[] args)
    {
        while (true)
        {
        const double COST_PER_HOUR = 86.0;
        const double SQFT_PER_HOUR = 20.0;
        const char INPUT_TRIANGLE = 't';
        const char INPUT_RECTANGLE = 'r';
        const char INPUT_CIRCLE = 'c';
        double area = 0.0;

        Console.WriteLine($"Pls choose the shape of your job area, where t=triangular, r=rectangular, c=circular: {INPUT_TRIANGLE} /{INPUT_RECTANGLE} / {INPUT_CIRCLE} ?");
        char shapeOfJob = Convert.ToChar (Console.ReadLine());

        if (shapeOfJob != INPUT_TRIANGLE && shapeOfJob != INPUT_RECTANGLE && shapeOfJob != INPUT_CIRCLE)
        {
            Console.WriteLine($"invalid Entry! user must choose either {INPUT_TRIANGLE} , {INPUT_RECTANGLE} , or {INPUT_CIRCLE}");
            return;
        }

        if (INPUT_TRIANGLE == shapeOfJob)
        {
            Console.WriteLine("Pls what is the base of the Triangle ?");
            double baseOfTriangle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pls what is the height of the triangle");
            double heightOfTriangle = Convert.ToDouble(Console.ReadLine());

            area =  (baseOfTriangle * heightOfTriangle)/2;
        }

        if (INPUT_RECTANGLE == shapeOfJob)
        {
            Console.WriteLine("Please type in the Lenght in meters and press enter");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please type in the Width in meters and press enter");
            double width = Convert.ToDouble(Console.ReadLine());

            area = length * width;
        }

        if (INPUT_CIRCLE == shapeOfJob)
        {
            Console.WriteLine("Please type in the Radius in meters and press enter");
            double radius = Convert.ToDouble(Console.ReadLine());

            area = (radius * radius * Math.PI);
        }

        Console.WriteLine($"Total area of the job is {area} squ feet.");

        Console.WriteLine("what is the cost of flooring one unit area of your job area ?");
        double flooringCostPerUnitArea = Convert.ToDouble(Console.ReadLine());

        double flooringCost = area * flooringCostPerUnitArea;
        Console.WriteLine($"the cost of flooring your job area is {flooringCost} Dollars");

        double labourCost = area * COST_PER_HOUR / SQFT_PER_HOUR;
        Console.WriteLine($"The labour cost at the rate of {COST_PER_HOUR} dollars per hour ({SQFT_PER_HOUR} tile per hr) is {labourCost} dollars.");

        double totalCost = flooringCost + labourCost;
        Console.WriteLine($"And the Total cost of job is {totalCost} dollars.");

        Console.WriteLine("Press Enter to play again or any other key to exit.");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                break;
            }
            Console.WriteLine("\n");
        }

    }
}



