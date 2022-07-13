
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите десятичное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int q = 0;
        int i = 0;



        int[] newArray = new int[100];

        while (number >= 1)
        {
            q = number % 2;
            newArray[i] = q;
            i++;

            number /= 2;
            Console.Write(q);
        }
        Console.Write(" -> ");

        int[] ReversArray(int[] inArray)
        {
            int[] result = new int[inArray.Length];
            for (int j = 0; j < inArray.Length; j++)
            {
                result[j] = inArray[inArray.Length - 1 - j];
            }

            return result;
        }
        int[] reversArray = ReversArray(newArray);
        Console.WriteLine(string.Join("", reversArray));

        // void ReversArray1(int[] inArray)
        // {
        //     for (int i = 0; i < inArray.Length / 2; i++)
        //     {
        //         int k = inArray[i];
        //         inArray[i] = inArray[inArray.Length - i - 1];
        //         inArray[inArray.Length - i - 1] = k;
        //     }
        // }

        // ReversArray1(newArray);
        // Console.WriteLine(String.Join("", newArray));

        Console.Write("Десятичное число: ");
        int dec = Convert.ToInt32(Console.ReadLine());

        string bin = string.Empty;
        while (dec > 0)
        {
            bin = dec % 2 + bin;
            dec /= 2;
        }

        Console.WriteLine($"Двоичное число: {bin}");
    }
}