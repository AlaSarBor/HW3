// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
System.Console.WriteLine("введите количество чисел, которое хотите ввести");
int lenght = Convert.ToInt32(Console.ReadLine()!);
int quantity = 0;
for (int i = 0; i <= lenght - 1; i++)
{
    int a = Convert.ToInt32(Console.ReadLine()!);
    if (a > 0)
    {
        quantity++;
    }
}
System.Console.WriteLine(quantity);


