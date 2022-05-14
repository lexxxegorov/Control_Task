# Итоговая проверочная работа.


## Задача:

*Написать программу, которая принимает из имеющегося массива строк, формируют массив из строк, длина которых 
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обоитись исключительно масствами.*

## КОД
**Вводим с клавиатуры строчный массив**

`Console.WriteLine("Введите 5 строк с символами через Enter:");`

`string[] strArray = new string[5];`

`for (int i = 0; i < strArray.Length; i++)`

`{`

    `strArray[i] = Console.ReadLine();`

`}`

**Запускаем метод для формирования массива с элементами, кол-во символов которых, не превышает трех**

`string[] SearchSimvol(string[] strArray)`

*Ищем кол-во элементов удовлетворяющих условию, для того , чтобы определить размер нового массива*

`{`


    
    int count = 0;

    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] sortStrArray = new string[count];

*заполняем новый массив элементами, которые удовлетворяют условие*

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
`}`

**Выводим на печать новый строчный массив**

`void PrintArray(string[] sortArray)`

`{`

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
`}`

`string[] newStrArray = SearchSimvol(strArray);`

`Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа");`

`PrintArray(newStrArray);`


