// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

Console.Write("Задайте строку, содержащую латинские буквы в обоих регистрах: ");
string words = Console.ReadLine();
Console.WriteLine();

Console.WriteLine(string.Join(' ', StringToLover(words)));

string StringToLover(string word)
{
    string sLow = word.ToLower();
    return sLow;
}