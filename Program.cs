using System;

namespace eccezioni 
{
    internal class Program
    {
        static int EseguiDivisione(int a, int b)
        {
            return a / b;
        }

        static string hello(string  name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return "Hello " + name;

        }
        static void Main(string[] args)
        {
            /*
            try
            {
                string? mioNome = null;
                Console.WriteLine(mioNome);
                //Console.WriteLine(hello(mioNome));

                //Un esempio di codice che genera eccezione (dividendo 0   oppure stringa non intero in input)
                Console.WriteLine("Inserisci il divisore:");
                string sA = Console.ReadLine();
                Console.WriteLine("Inserisci il dividendo:");
                string sB = Console.ReadLine();

                int iDivisore = Convert.ToInt32(sA);
                int iDividendo = Convert.ToInt32(sB);

                int iRes = EseguiDivisione(iDivisore, iDividendo);
                Console.WriteLine($"Risultato della divisione: {iRes}");

            }
            catch (Exception ex)
            {
                // Codice da eseguire in caso di eccezione.
                Console.WriteLine("È avvenuta la seguente eccezione: {0}", ex.Message);
                // Proprietà interessanti nella gestione dell'eccezione.
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Source: " + ex.Source);
                Console.WriteLine("StackTrace: " + ex.StackTrace);
            }
            
            int b = 1; int c = 5;
            try
            {
                var a = 1;
                b = a - 1;
                c = a / b;
                a = a / c;
            }
            catch (DivideByZeroException dEx) when (b == 0)
            {
                // we're throwing the same kind of exception
                throw new DivideByZeroException("Cannot divide by b because it is zero", dEx);
            }
            catch (DivideByZeroException dEx) when (c == 0)
            {
                // we're throwing the same kind of exception
                throw new DivideByZeroException("Cannot divide by c because it is zero", dEx);
            }*/

            try
            {
                string? text = null;
                int length = text.Length;
                Console.WriteLine(length);
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
    }
}