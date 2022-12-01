// Программа, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнение алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] Array1 = new string[6] { "hello", "2", "world", ":-)", "yes", "ok" };

string[] ArrayLength(string[] Array1)
{

    int count = default;
    for (int i = 0; i < Array1.Length; i++)
    {
        if (Array1[i].Length <= 3)
        {
            count++;
        }
    }

    string[] Array2 = new string[count];

    return Array2;
}

string[] NewArray(string[] arr1, string[] arr2)
{

    int count = default;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }

    }
    return arr2;
}

void PrintArray(string[] final)
{
    Console.Write("[ ");
    for (int i = 0; i < final.Length; i++)
    {
        if (i < final.Length - 1) Console.Write($"{final[i]},  ");
        else Console.Write($"{final[i]}");
    }
    Console.Write(" ]");
}

string [] OldArray = ArrayLength (Array1);
string [] NewArr = NewArray (Array1,OldArray);
PrintArray (NewArr);
