Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("ВИЗИТКА СИСТЕМЫ");
Console.ResetColor();

string studentName = "Серебряков Максим";
string studentGroup = "ПМБИ-261";
string favLanguage = "C#";
string codingYears = "1 год";
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n[Студент]");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Имя:        {studentName}");
Console.WriteLine($"Группа:     {studentGroup}");
Console.WriteLine($"Язык:       {favLanguage}");
Console.WriteLine($"Опыт:       {codingYears}");
Console.WriteLine($"Дата:       {DateTime.Now:dd.MM.yyyy HH:mm}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Компьютер]");
Console.ResetColor();
Console.WriteLine($"Имя машины:      {Environment.MachineName}");
Console.WriteLine($"Пользователь:    {Environment.UserName}");
Console.WriteLine($"ОС:              {Environment.OSVersion}");
Console.WriteLine($"64-битная ОС:    {Environment.Is64BitOperatingSystem}");
Console.WriteLine($"Версия .NET:     {Environment.Version}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Процессор]");
Console.ResetColor();
Console.WriteLine($"Логических ядер: {Environment.ProcessorCount}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Память]");
Console.ResetColor();
long workingSetMb = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса: {workingSetMb} МБ");
Console.WriteLine($"Размер указателя: {IntPtr.Size * 8} бит");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nПрограмма выполнена успешно!");
Console.ResetColor();

Console.WriteLine("\n[Все цвета ConsoleColor]");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Black");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("DarkBlue");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("DarkGreen");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("DarkCyan");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("DarkRed");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("DarkMagenta");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("DarkYellow");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Gray");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("DarkGray");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Blue");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Green");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Cyan");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Red");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Magenta");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Yellow");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("White");
Console.ResetColor();