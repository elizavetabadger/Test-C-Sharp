﻿/* В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
Покажите все слова, состоящие из 2 букв, которые можно построить из букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс*/
Console.Clear();

char[] alphabet = {'a', 'и', 'c', 'в'};
 
Console.Write("Сколько букв в слове? ");
int num = int.Parse(Console.ReadLine()!);
 
char[] word = new char[num];
 
WriteWord(alphabet, word);
 
void WriteWord(char[] array, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($" {new String(word) }");
        return;
    }
 
    for (int i = 0; i < array.Length; i++)
    {
        word[length] = array[i];
        WriteWord(array, word, length + 1);
    }
}