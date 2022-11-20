// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] GetArrayFromString(string strArray)
{
    string[] nums = strArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] resArr = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        resArr[i] = Convert.ToInt32(nums[i]);
    }
    return resArr;
}

void SummPositive (int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) summ++;
    }
Console.WriteLine($"Количество введённых положительных чисел: {summ}");
}

Console.Clear();
Console.Write("Введите числа через пробел: ");
string? elements = Console.ReadLine();
int[] arr = GetArrayFromString(elements);
SummPositive(arr);

