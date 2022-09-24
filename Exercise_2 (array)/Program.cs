// Отсортировываем массив по возрастанию элементов

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; // обозначили массив

void PrintArray(int[] array) // #1 : метод, выводящий этот массив на экран 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); //  само число array под индексом i
    }
    Console.WriteLine();
}
void SelectionSort(int[] array) // #2 : метод, упорядочивающий наш массив
{
    for (int i = 0; i < array.Length - 1; i++) // пробегаемся по всем эл-там, находим min , array-1 – потому что в последней итерацией мы срваниваем i и i+1 – два последних элемента
    { 
        int minPosition = i; // тут мы предполагаем, что минимальное значение у элемента с позицией (индексом) i
        for (int j = i + 1; j < array.Length; j++) 
        {
            if(array[j] < array[minPosition]) // сравниваем элементы, находим min
            {
                minPosition = j;
            }
        }
        int temporary = array[i]; // алгоритм замены местами элементов
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);