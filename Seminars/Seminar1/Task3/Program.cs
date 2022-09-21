Console.Clear();

Console.Write("Введите порядковый номер дня недели: ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number == 1) {
    Console.WriteLine ("Monday");
}
else if (number == 2) {
    Console.WriteLine ("Tuesday");
}
else if (number == 3) {
    Console.WriteLine ("Wednesday");
}
else if (number == 4) {
    Console.WriteLine ("Thursday");
}
else if (number == 5) {
    Console.WriteLine ("Friday");
}
else if (number == 6) {
    Console.WriteLine ("Saturday");
}
else if (number == 7) {
    Console.WriteLine ("Sunday");
}
else {
    Console.WriteLine ("The Universe doesn't have such a day of the week");
}
