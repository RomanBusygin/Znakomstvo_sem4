double b1 = Input_factors("Введите коэффициент b1: ");
double k1 = Input_factors("Введите коэффициент k1: ");
double b2 = Input_factors("Введите коэффициент b2: ");
double k2 = Input_factors("Введите коэффициент k2: ");

Console.Write($"Точка пересечения двух прямых с введенными коэффициентами будет иметь координаты: ({(b2 - b1) / (k1 - k2)};{k1 * (b2 - b1) / (k1 - k2) + b1})");

double Input_factors (string line)
{
    Console.Write(line);
    return Convert.ToDouble(Console.ReadLine());
}