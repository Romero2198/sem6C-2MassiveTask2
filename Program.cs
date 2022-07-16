double b1 = InputInt("Введите b1: ");
double k1 = InputInt("Введите k1: ");
double b2 = InputInt("Введите b2: ");
double k2 = InputInt("Введите k2: ");
double x = (b2 - b1) / (k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({y1}; {y2})");


int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}