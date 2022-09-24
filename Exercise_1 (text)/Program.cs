/* Дан текст. В тексте нужно все пробелы заменить вертикальными чёрточками |, 
маленькие буквы "к" заменить большими "К", 
а большие "С" заменить маленькими "с".*/

string text = "– Я не думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Виценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так кросноречивы. Вы дадите мне чаю?"; 

// string s = "qwerty";
//             012345  - определённый символ – определённая цифра, как индекс
// s[3] = r

string Replace(string text, char oldValue, char newValue) // Replace – название метода, 
// string text – определённая строка
// char oldValue – определённый старый символ (который меняем)
// char newValue – определённый новый символ (НА который меняем)
{
    string result = String.Empty;
    int length = text.Length; // обозначает количество символов в тексте 
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) // если мы нашли старое значение, то в строку ставим новое значение
        {
           result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}"; // если мы не нашли старое значение, то оставляем как есть 
        }
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'В', 'в');
Console.WriteLine(newText);