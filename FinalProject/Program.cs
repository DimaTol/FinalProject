// Программа, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнение алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] Array1 = new string[8] { "hello", "2", "world", ":-)", "-2", "yes", "strong", "ok" };

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