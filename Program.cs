
Console.Write("Введите миллиметры:");
const double SM = 0.1;
const double Metr = 0.001;
const double KM = 0.000001;
const double Mili = 6.21371E-7;
const double Yards = 914.4;
double mm = double.Parse(Console.ReadLine());

Console.WriteLine($"{mm} миллиметров = {mm * SM:F2} сантиметров");
Console.WriteLine($"{mm} миллиметров = {mm * Metr} метров");
Console.WriteLine($"{mm} миллиметров = {mm * KM:F6} километров");
Console.WriteLine($"{mm} миллиметров = {mm * Mili:F6} миль");
Console.WriteLine($"{mm} миллиметров = {mm / Yards:F2} ярдов");



