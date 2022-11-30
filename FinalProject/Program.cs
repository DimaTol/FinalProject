// Программа, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнение алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string [] Array1 = new string [6] {"hello", "2", "world", ":-)", "yes", "string",};


string[] NewArray(string[] newarray)
{

    int count = 0;
    for (int i = 0; i < newarray.Length; i++)
    {  
        if (newarray[i].Length <= 3)
        {
            newarray[count] = newarray[i];
            count++;
        }

    }
    return newarray;

}

void PrintArray(string[] final)
{
    Console.Write("[");
    for (int i = 0; i < final[i].Length; i++)
    {
        if (i < final[i].Length) Console.Write($"{final[i]}, ");
    }
    Console.Write("]");
}

//  string [] NewArray1 = NewArray(Array1);

// PrintArray (NewArray1);