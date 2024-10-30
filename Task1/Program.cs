// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []




Console.WriteLine("Введите элементы массива через пробел:");
string input = Console.ReadLine();
string[] initialArray = input.Split(' ');

int count = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        count++;
    }
}

string[] resultArray = new string[count];

int index = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        resultArray[index] = initialArray[i];
        index++;
    }
}

Console.WriteLine("Результат: ");
Console.WriteLine(string.Join(", ", resultArray));
