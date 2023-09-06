Console.WriteLine("Tipo de fruta");
Console.WriteLine("1) Naranja");
Console.WriteLine("2) Fresa");
Console.WriteLine("3) Mango");
string tipoTexto = Console.ReadLine();

Console.WriteLine("Ingrese la distancia: ");
string distanciaTexto = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de cajas a transportar:");
string cantidadCajas = Console.ReadLine();

float cantidad = float.Parse(cantidadCajas);
float distancia = float.Parse(distanciaTexto);
int tipoFruta = int.Parse(tipoTexto);
float pago = 0f;

switch (tipoFruta)
{
    case 1:
        if (distancia < 30)
        {
            pago = 2*cantidad;
        }
        else
        {
            pago = 4*cantidad;
        }
        break;
    case 2:
        if (distancia < 30)
        {
            pago = 6 * cantidad;
        }
        else
        {
            pago = 9 * cantidad;
        }
        break;
    case 3:
        if (distancia < 30)
        {
            pago = 3*cantidad;
        }
        else
        {
            pago = 5*cantidad;
        }
        break;
    default:
        Console.WriteLine("Porfavor Ingrese una de las opciones correspondientes.");
        break;
}

Console.WriteLine("El pago es: S/" + pago);
Console.ReadLine();