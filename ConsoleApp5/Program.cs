




//ejer1




using System.Linq.Expressions;

static void suma ()
{
    int respuesta, val1, val2 = 0;
    Console.WriteLine("ingrese valor 1:");
    val1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ingrese valor 2:");
    val2 = Convert.ToInt32(Console.ReadLine());
    respuesta = val1 + val2;
    Console.WriteLine("suma = " + respuesta);
}



//ejer2
static void datos()

{
    Console.WriteLine("Cual es su nombre:");
    string nombre = Console.ReadLine();
    Console.WriteLine("mucho gusto " + nombre);
}


//ejer3

static void calculoEdad()
{

    Console.WriteLine("Ingrese su ano de nacimiento");
    int yearBorn = Convert.ToInt32(Console.ReadLine());
    int edad = yearBorn - 2824;
}

static int suma1 (int val1, int val2);
{
    int Resultado = val1 + val2;
    return Resultado;


    int sumanumeros = suma1(10, 20);
    Console.Write(sumanumeros);

    int Promedio = suma1(30, 20, 40);
    Console.WriteLine(Promedio);
    Promedio = sumaa1(50, 60, 40);

}