// Написать программу, которая из имеющегося массива строк  
// формирует массив из строк, длина которых меньше либо равна  
// 3 символа. Первоначальный массив можно ввести с клавиатуры,  
// либо задать на старте выполнения алгоритма. При решении не  
// рекомендуется пользоваться коллекциями, лучше обойтись  
// исключительно массивами.

// ["hello","2","world",":-)"] -> ["2",":-)"]  
// ["1234","1567","-2","computer science"] -> ["-2"]  
// ["Russia","Denmark","Kazan"] -> []

Console.WriteLine("Введите любое количество строк через запятую:");

string[] strMassive;
string? str = Console.ReadLine();
strMassive = str!.Split(',');

void PrintLimitMassive(string[] matrix, int limit)
{
    int i = 0;
    for (i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= limit)
        {
            Console.Write($"{matrix[i]}");
            i++;
            break;            
        }
    }
    while (i < matrix.Length)
    {
        if (matrix[i].Length <= limit)
        {
            Console.Write($", {matrix[i]}");            
        }
        i++;        
    }
}

PrintLimitMassive(strMassive, 3);