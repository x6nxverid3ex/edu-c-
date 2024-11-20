using System;

class Program2
{
    static void Main2()
    {
        bool isTautology = true;

        Console.WriteLine(" p | q | r | (p || q) | (q == r) | (!p || r)   |   Final Expression\n");
        Console.WriteLine("----------------------------------------------------------");

        for (int p = 0; p <= 1; p++)
        {
            for (int q = 0; q <= 1; q++)
            {
                for (int r = 0; r <= 1; r++)
                {
                    bool pOrQ = Convert.ToBoolean(p) || Convert.ToBoolean(q);
                    bool qIfFR = Convert.ToBoolean(q) == Convert.ToBoolean(r); // q еквівалентно r (q ⇔ r)
                    bool notPOrR = !Convert.ToBoolean(p) || Convert.ToBoolean(r);

                    // Остаточний логічний вираз
                    bool finalExpression = (pOrQ && qIfFR) || notPOrR;


                    if (!finalExpression)
                    {
                        isTautology = false;
                    }

                    // Виведення результатів для кожної комбінації
                    Console.WriteLine($"{p}   |  {q}   |  {r}   |  {(pOrQ ? 1 : 0)}      |  {(qIfFR ? 1 : 0)}    |  {(notPOrR ? 1 : 0)}    |   {(finalExpression ? 1 : 0)}");
                }
            }
        }

        // Перевірка та виведення результатів
        Console.WriteLine("\nРезультати перевірки:");
        if (isTautology)
        {
            Console.WriteLine("Це тавтологія.");
        }
        else
        {
            Console.WriteLine("Це не тавтологія.");
        }
    }
}
