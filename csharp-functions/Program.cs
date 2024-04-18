namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numList = { 2, 6, 7, 5, 3, 9 };

            void StampaArray(int[] array)
            {
                Console.Write("[");
                for(int i  = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if(i < array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("]\n");
            }

            int Quadrato(int numero)
            {
                return numero * numero;
            }

            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] newArray = new int[array.Length];

                for(int i = 0;i < array.Length;i++)
                {
                    newArray[i] = array[i] * array[i];
                }

                return newArray;
            }

            int sommaElementiArray(int[] array)
            {
                int somma = 0;
                foreach(int i in array)
                {
                    somma += i;
                }
                return somma;
            }

            StampaArray(numList);
            Console.WriteLine(Quadrato(9));
            int[] arrayAlQuadrato = ElevaArrayAlQuadrato(numList);
            StampaArray(arrayAlQuadrato);
            Console.WriteLine(sommaElementiArray(numList));
        }
    }
}
