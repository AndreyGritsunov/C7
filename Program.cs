Console.Write("Введите день недели от 1 до 7 для определения выходной сегодня или нет: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7) Console.WriteLine("Нет такого дня недели");
if (number == 1) Console.WriteLine("Нет");
if (number == 2) Console.WriteLine("Нет");
if (number == 3) Console.WriteLine("Нет");
if (number == 4) Console.WriteLine("Нет");
if (number == 5) Console.WriteLine("Нет");
if (number == 6) Console.WriteLine("Да");
if (number == 7) Console.WriteLine("Да");

