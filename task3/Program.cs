// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

Console.Write("адайте строку, состоящую из слов, разделенных пробелами: ");
string words = Console.ReadLine();
Console.WriteLine();
Console.WriteLine(string.Join(' ', ConvertString(words)));

string[] ConvertString(string word)
{
    string[] split = word.Split(' ');
    string[] revers = split.Reverse().ToArray();
    return revers;
}
