

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Number of Sandwiches Desired");
int numberOfSandwiches = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number of Toppings Desired");
int numberOfToppings = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Tip Amount as a Decimal");
decimal tip = Convert.ToDecimal(Console.ReadLine());

decimal COST_OF_SANDWICH = 4.75m;
    
decimal COST_OF_TOPPING = 0.55m;
    
decimal DISCOUNT_AMOUNT = 0.10m;

decimal totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
decimal totalToppingCost = COST_OF_TOPPING * numberOfToppings;
decimal baseCost = totalSandwichCost + totalToppingCost;

decimal unrounded_orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);
decimal orderCost = Math.Round(unrounded_orderCost, 2);

Console.WriteLine("Your order cost is: $" + orderCost);

