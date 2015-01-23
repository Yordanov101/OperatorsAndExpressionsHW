using System;
class BitExchangeTwo
{
    // Program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit 
    // unsigned integer.The first and the second sequence of bits may not overlap.
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int pBits = int.Parse(Console.ReadLine());
        int qBits = int.Parse(Console.ReadLine());
        int kBits = int.Parse(Console.ReadLine());


        if (pBits > qBits)
        {
            int oldValue = pBits;
            pBits = qBits;
            qBits = oldValue;
        }

        if (pBits + kBits >= qBits)
        {
            kBits += pBits - qBits - 1;
            qBits += pBits + kBits + 1;
        }

        number = ModifyNumber(number, pBits, qBits, kBits);

        Console.WriteLine(number);
    }

    private static uint ModifyNumber(uint number, int p, int q, int k)
    {
        int[] pBits = new int[k];
        int[] qBits = new int[k];

        for (int position = p, i = 0; i < pBits.Length; position++, i++)
        {
            pBits[i] = PthBit(number, position);
        }

        for (int position = q, i = 0; i < qBits.Length; position++, i++)
        {
            qBits[i] = PthBit(number, position);
        }

        for (int position = p, i = 0; i < qBits.Length; position++, i++)
        {
            number = ModifiedNumber(number, position, qBits[i]);
        }

        for (int position = q, i = 0; i < pBits.Length; position++, i++)
        {
            number = ModifiedNumber(number, position, pBits[i]);
        }
        return number;
    }
    private static int PthBit(uint number, int position)
    {
        uint pthBit = (number >> position) & 1;
        return (int)pthBit;
    }
    private static uint ModifiedNumber(uint number,int position,int bitValue)
    {
        uint actualP = (uint)bitValue << position;
        number = number & (~((uint)1 << position));
        uint result = number | actualP;
        return result;
    }
}
