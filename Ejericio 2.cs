internal class Program


{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba dos valores numericos");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n*****Menu Principal*****");
        Console.WriteLine("1-Suma");
        Console.WriteLine("2-Resta");
        Console.WriteLine("3-Multipilicacion");
        Console.WriteLine("4-Division");
        Console.WriteLine("5-Salir");
        Console.WriteLine("Digite el valor segun sea la operacion , []");
        int opc = Convert.ToInt32(Console.ReadLine());

        //Evaluar con switch
        string msj = "";
        double result = 0;
        switch (opc)
        {
            case 1:

                msj = "\nSuma\nLa suma es:";
                result = num1 + num2;
                break;

            case 2:

                msj = "\nResta\nLa resta es:";
                result = num1 - num2;
                break;

            case 3:

                msj = "\nMultiplicacion\nLa Multiplicacion es:";
                result = num1 * num2;
                break;

            case 4:

                msj = "\nDivision\nLa Division es:";
                result = num1 / num2;
                break;

            case 5:

                msj = "Saliendo del sistema";

                break;
            default:
                msj = "Digite una opcion valida";
                break;
        }
                Console.Clear();
                Console.WriteLine(msj);
                Console.WriteLine(result);

        }
}
