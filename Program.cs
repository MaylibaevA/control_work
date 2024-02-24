using System.Runtime.InteropServices.Marshalling;

Console.Clear();
Console.Write("Введите желаемое количество элементов Вашего массива:");
Console.WriteLine();
int indexAmount = Convert.ToInt32(Console.ReadLine());
string[] strings = new string[indexAmount];
int index = 0;
while (indexAmount > index)
{
    Console.Write("Введите свое значение:");
    Console.WriteLine();
    strings[index] = Console.ReadLine();
    index++;
}

void CheckStrings(string[] strings)
{
    int indexOfString = 0;
    int count = 0;
    int countOfOk = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        count = 0;
        indexOfString = 0;
        while (indexOfString < strings[i].Length)
        {
            count++;
            indexOfString++;
        }
        if(count <= 3)
        {
            Console.WriteLine(strings[i]);
            countOfOk++;
        }
    }
    if(countOfOk == 0)
        Console.WriteLine("Нет подходящих значений");
}

CheckStrings(strings);