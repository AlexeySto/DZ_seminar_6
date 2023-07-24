// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] GetNumbers(string messaeg)                  // Запрашиваем у пользователя числа
{
    Console.Write(messaeg);
    string[] numbers = Console.ReadLine()!.Split();
    return numbers;
}

int GetCountPositivNum(string[] numbers)           // Выводит количество элементов больше 0
{
    int res = 0;
    foreach (string el in numbers)
    {
        int num = Convert.ToInt32(el);
        if (num > 0 ) res++;
    }
    return res;
}

string[] arrayNumbers = GetNumbers("Введите числа через пробел: ");
int countPositiv = GetCountPositivNum(arrayNumbers);
Console.Write(String.Join(", ", arrayNumbers));
Console.Write($" -> {countPositiv}");