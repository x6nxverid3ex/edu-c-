using System;

class Program
{
    static void Main()
    {
        bool isTautology = true;
        bool isNeutral = true;

        Console.WriteLine(" p | q | r |  !p  | !p && r | !p && q | !p && !q | q || r | (q || r) => r | (!(p && q) || (!p && q) || (!p && !q)) => r | ((q || !p) => r) && ((q || p) => r)\n");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

        for (int p = 0; p <= 1; p++)
        {
            for (int q = 0; q <= 1; q++)
            {
                for (int r = 0; r <= 1; r++)
                {
                    bool notP = !Convert.ToBoolean(p);
                    bool notPandR = notP && Convert.ToBoolean(r);
                    bool notPandQ = notP && Convert.ToBoolean(q);
                    bool qOrR = Convert.ToBoolean(q) || Convert.ToBoolean(r);
                    bool qOrRImpliesR = !qOrR || Convert.ToBoolean(r);
                    bool finalExpression = (notPandR || notPandQ || !notP) || qOrRImpliesR;

                    if (!finalExpression) isTautology = false;

                    if (finalExpression == (notPandR || notPandQ)) isNeutral = false;

                    Console.WriteLine($"{p,2} | {q,2} | {r,2} | {Convert.ToInt32(notP),4} | {Convert.ToInt32(notPandR),9} | {Convert.ToInt32(notPandQ),9} | {Convert.ToInt32(!notP),10} | {Convert.ToInt32(qOrR),7} | {Convert.ToInt32(qOrRImpliesR),13} | {Convert.ToInt32(finalExpression),39}");
                }
            }
        }

        Console.WriteLine("\nРезультати перевірки:");
        if (isTautology)
        {
            Console.WriteLine("Це тавтологія.");
        }
        else if (isNeutral)
        {
            Console.WriteLine("Це нейтральне твердження.");
        }
        else
        {
            Console.WriteLine("Твердження хибне.");
        }
    }
}
