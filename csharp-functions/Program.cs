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
                    newArray[i] = Quadrato(array[i]);
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

            Console.Write("Ecco il nostro Array: ");
            StampaArray(numList);

            Console.Write("\nBene, ora vediamo l'array elevato completamente al quadrato: ");
            StampaArray(ElevaArrayAlQuadrato(numList));
            Console.Write("E possiamo notare che il nostro array è rimasto invariato: ");
            StampaArray(numList);

            Console.Write($"\nEcco qui la somma di tutti i numeri della lista originale: {sommaElementiArray(numList)}");

            Console.Write($"\n\nE invece ecco qua la somma di tutti gli elementi al quadrato: {sommaElementiArray(ElevaArrayAlQuadrato(numList))}");
            
            //BONUS


        }
    }
}
