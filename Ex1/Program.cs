/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

Console.Write("Введите числа через запятую: ");
string text = Console.ReadLine();
char symbol = ',';
int count = 0;
string[] words = text.Split(symbol);
int[] numbers = new int[words.Length];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(words[i]);
    if (numbers[i] > 0)
    {
        count++;
    }
}

if (count % 10 == 1)
{
    Console.WriteLine($"{count} число больше 0 ввёл пользователь");
}
else if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4)
{
    Console.WriteLine($"{count} числа больше 0 ввёл пользователь");
}
else
{
    Console.WriteLine($"{count} чисел больше 0 ввёл пользователь");
}