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

string [] ChechString (string [] strings)
{
    string [] stringwithemptiness = new string [strings.Length];
    int countOfOk = 0;
    for(int i = 0; i < strings.Length; i++)
    {
        int count = 0;
        int indexOfString = 0;
        while (indexOfString < strings[i].Length)
        {
            count++;
            indexOfString++;
        }
        if(count <= 3)
        {
            stringwithemptiness[i] = strings[i];
            countOfOk++;
        }
    }
    string [] normalstring = new string [countOfOk];
    int b = 0;
    for(int i = 0; i < stringwithemptiness.Length; i++)
    {
        if (stringwithemptiness[i] != null)
        {
            normalstring[b] = stringwithemptiness[i];
            b++;
        }
    }
    return normalstring;
}

void ShowArray (string [] strings)
{
    for (int i = 0; i < strings.Length; i++)
    {
        Console.Write(strings[i]);
        if (i < strings.Length - 1)
            Console.Write(", ");
    }
}

ShowArray(ChechString(strings));