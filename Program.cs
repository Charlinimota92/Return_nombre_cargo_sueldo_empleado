// See https://aka.ms/new-console-template for more information
Console.WriteLine("Empleado");
Console.WriteLine();

{
    
    Console.WriteLine("Ingrese el nombre del empleado:");
    string nombreEmpleado = Console.ReadLine();

    Console.WriteLine("Ingrese el cargo del empleado:");
    string cargoEmpleado = Console.ReadLine();

    Console.WriteLine("Ingrese el sueldo del empleado:");
    double sueldoEmpleado = Convert.ToDouble(Console.ReadLine());

    MostrarDatosEmpleado(nombreEmpleado, cargoEmpleado, sueldoEmpleado);
}

static void MostrarDatosEmpleado(string nombre, string cargo, double sueldo)
{
    Console.WriteLine("\nDatos del empleado:");
    Console.WriteLine("Nombre: " + nombre);
    Console.WriteLine("Cargo: " + cargo);
    Console.WriteLine("Sueldo: " + sueldo);
}

