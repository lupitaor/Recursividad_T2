namespace Recursividad.Logica
{
    public class Factorial
    {
        public int MiFactorial(int numero)
        {
            //Caso base o condición de salida
            if (numero == 1)
            {
                return 1;
            }

            //Caso genera

            return numero = numero * MiFactorial(numero - 1);
        }



    }
}
