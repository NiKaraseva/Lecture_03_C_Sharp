// Цикл for

string Method4(int count, string text)
{
    string result = String.Empty; // или так: "";
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "ТекстХот");
Console.WriteLine(res);