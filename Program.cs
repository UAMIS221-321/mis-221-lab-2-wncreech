class Program {
    static int PromptIntInput(string message, string errorMessage)
    { //for the purpose of the sandwich shop, # sandwich and toppings must be an integer >= 0
        Console.WriteLine(message);
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int validInt) && validInt >= 0) 
            {
                return validInt;
            }
            else 
            {
                Console.WriteLine(errorMessage);
            }
        }
    }

    static double PromptDblInput(string message, string errorMessage)
    { //tip must be real number >= 0
        Console.WriteLine(message);
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double validTip) && validTip >= 0) 
            {
                validTip = Math.Round(validTip, 2); //rounds to nearest cent//
                return validTip;
            }
            else 
            {
                Console.WriteLine(errorMessage);
            }
        }
    }

    static void Main() 
    {
        const double COST_OF_SANDWICH = 4.75;
        const double COST_OF_TOPPING = 0.55;
        const double DISCOUNT_AMOUNT = 0.1;

        double totalSandwichCost;
        double totalToppingCost;
        double baseCost;

        Console.WriteLine("Welcome to Sherlenthia's Sandwich Shop!");
        int numberOfSandwiches = PromptIntInput("How many sandwiches would you like?", "Invalid input. Please order a whole number of sandwiches.");
        int numberOfToppings = PromptIntInput("How many toppings would you like?", "Invalid input. Please order a whole number of toppings.");
        double tip = PromptDblInput("What would you like to leave as a tip?", "Invalid input. Please enter a real number greater than or equal to 0.");

        totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
        totalToppingCost = COST_OF_TOPPING * numberOfToppings;
        baseCost = totalSandwichCost + totalToppingCost;
        double orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);

        Console.WriteLine();
        if (tip == 0) Console.WriteLine ("(The cashier looks highly disappointed by your lack of tip.)");
        Console.WriteLine("Your total is {0:C}. Thank you, come again!", orderCost); 
    }
}