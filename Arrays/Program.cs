//string[] fruit = { "apples", "bananas", "oranges" };
string[] fruit = new string[3];
fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";

int fruitArrayLength = fruit.Length;
Console.WriteLine($"There are {fruitArrayLength} fruits in your array.");

for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string element in fruit)
{
    Console.WriteLine(element);
}