static double PromptInput(string message) {
    Console.WriteLine(message);
    Console.WriteLine("\n");
    double output = double.Parse(Console.ReadLine());
    return output;
}

static void main() {
    const double COST_OF_SANDWICH = 4.75
    const double COST_OF_TOPPING = 0.55;
    const double DISCOUNT_AMOUNT = 0.1;

    double totalSandwichCost = 0;
    double totalToppingCost = 0;
    double baseCost = 0;

    PromptInput("Number of sandwiches?\n");
    PromptInput("Number of toppings?\n");
}