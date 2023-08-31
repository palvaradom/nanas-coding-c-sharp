// Crear un programa que calcule el área del rectángulo
double ladoA;
double ladoB;
double resultado;

Console.WriteLine("Ingrese el lado A: ");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el lado B: ");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("Resultado: " + resultado);