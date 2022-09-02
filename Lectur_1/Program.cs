// ВозвращаемыйТипДанных ИмямМтода([ТипДанных1, Аргумент1, ...])
// {
//     Тело метода
//     return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }

// 1 группа методов которые ничего не принимают и ничего не возвращают

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// // Как вызываются подобные методы
// Method1();

// 2 группа методов которые принимают какие-то аргументы и ничего не возвращают

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Как вызываются подобные методы
// Method2(msg: "Текст сообщения");
// Еще вариант использования этого метода
// void Method22(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Как вызываются подобные методы
// Method22(msg:"Текст ", count: 4);

// 3 группа методов которые принимают какие-то аргументы  но возвращают

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3();
// Console.WriteLine(Year);

// 4 группа методов которые что-то принимают и что-то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Текст ");
// Console.WriteLine(res);

// Цикл for
// for(int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// ПРИМЕР

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//    for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "Текст ");
// Console.WriteLine(res);

// ЦИКЛ В ЦИКЛЕ 
// ПРИМЕР ЗАДАЧИ (ВЫВОД ТАБЛИЦЫ УМНОЖЕНИЯ)

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// ПРИМЕР ЗАДАЧИ ИЗ ЛЕКЦИИ
// Дан текст: в тексте нужно все пробелы заменить черточнками, маленикие буквы "к" заменить большими "К", а большие "с" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нащего милого Винцегероде,"
            + "вы бы взяли приступом приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "eufm";
//             0123
// s[3] //m           
// string Replase(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int lenght = text.Length;
//     for(int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replase(text, ' ', '-');
// Console.WriteLine();
// Console.WriteLine(newText);

// newText = Replase(newText, 'к', 'К');
// Console.WriteLine();
// Console.WriteLine(newText);

// newText = Replase(newText, 'С', 'с');
// Console.WriteLine();
// Console.WriteLine(newText);

// ВТОРОЙ ПРИМЕР: ЗАДАЧА НА СОРТИРОВКУ МАССИВА

int[] arr ={ 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SlectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SlectionSort(arr);

PrintArray(arr);