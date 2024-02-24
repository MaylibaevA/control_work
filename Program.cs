Console.Clear();
Console.Write("Введите желаемое количество элементов Вашего массива:");
Console.WriteLine();
int indexAmount = Convert.ToInt32(Console.ReadLine());
string [] strings = new string [indexAmount];
int index = 0;
while(indexAmount > index)
{
    Console.Write("Введите свое значение:");
    Console.WriteLine();
    strings[index] = Console.ReadLine();
    index++;
}

