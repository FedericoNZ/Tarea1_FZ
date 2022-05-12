
string respuesta = "S";

while (respuesta == "S")
{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre:");
    string nombreUser = Console.ReadLine();

    Console.WriteLine($"¡Hola {nombreUser}!");
    Console.WriteLine("¿Desea continuar? (S/N)");
    respuesta = Console.ReadLine().ToUpper();
    switch (respuesta)
    {
        case "N":
            Console.WriteLine("Programa finalizado correctamente.");
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}