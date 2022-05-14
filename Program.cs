/* Написать программу, которая принимает из имеющегося массива строк, формируют массив из строк, длина которых 
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обоитись исключительно масствами.*/

Console.WriteLine("Введите 5 строк с символами через Enter:");
string[] strArray = new string[5];
for (int i = 0; i < strArray.Length; i++)
{
    strArray[i] = Console.ReadLine();
}

string[] SearchSimvol(string[] strArray)
{
    int count = 0;
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] sortStrArray = new string[count];
    int index = 0;
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            sortStrArray[index] = strArray[i];
            index++;
        }
    }
    return sortStrArray;
}


void PrintArray(string[] sortArray)
{
    Console.Write("[");
    for (int i = 0; i < sortArray.Length; i++)
    {
        Console.Write(sortArray[i]);
        if (i != sortArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

string[] newStrArray = SearchSimvol(strArray);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа");
PrintArray(newStrArray);
