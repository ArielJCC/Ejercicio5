//Escribir un programa que lea exactamente 8 números y luego escriba la suma de todos ellos
internal class Program
{
    private static void Main(string[] args)
    {
        int num; int suma = 0; int i = 1;

        while(i <= 8)
        {
            Console.WriteLine("Digite cualquier número "+"("+i+")");
            num = int.Parse(Console.ReadLine());

            i++;
            suma = suma + num;
               
        }  
        Console.WriteLine("El resultado de la suma de los números es: "+suma);
    }
}