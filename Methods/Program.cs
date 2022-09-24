// ! МЕТОД 1: ничего не принимает и ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор: Карасева Ника");
}
// Method1();



// ! МЕТОД 2: что-то принимает, но ничего не возвращает

void Method2(string msg) //string - идентификатор, msg - какое-то количество аргументов
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");
// Method2( msg: "Текст сообщения"); - когда мы хотим указать, какому аргументу какое значение принадлежит

// Пример: 
void Method21(string msg, int count) // выдавать msg какое-то количество раз count
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("ТекстТекст", 4);
// Method21(msg: "ТекстТекст", count: 4); // именованные аргументы (можно в любом порядке)



// ! МЕТОД 3: ничего не принимают, но что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);



// ! МЕТОД 3: что-то принимают и что-то возвращают

string Method4(int count, string text) // будем строку text друг за другом компоновать count раз
{
    int i = 0;
    string result = String.Empty; // или так: "";
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "ТекстХот");
// Console.WriteLine(res);