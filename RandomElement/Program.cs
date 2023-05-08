
string[] snack = { "sushi", "pizza", "Burger", "Asian", "toner" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snack.Length);

Console.WriteLine($"Tonight we are going to eat {snack[randomIndex]}.");