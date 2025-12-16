using System;

class HappyTicketsFullSolution
{
    static void Main()
    {
        Console.WriteLine("Начинается поиск счастливых 6-значных билетов...");
        
        int totalHappyTickets = FindAndPrintHappyTickets();
        
   


   
        Console.WriteLine($"\n#### **Всего найдено счастливых билетов:** {totalHappyTickets}");
        Console.WriteLine("Поиск завершен.");
    }

    static int FindAndPrintHappyTickets()
    {
        int count = 0; 

        for (int ticketNumber = 0; ticketNumber <= 999999; ticketNumber++)
        {
            int temp = ticketNumber;
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < 3; i++)
            {
                sum2 += temp % 10;
                temp /= 10;
            }

            for (int i = 0; i < 3; i++)
            {
                sum1 += temp % 10;
                temp /= 10;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"{ticketNumber:D6}"); 
                count++;
            }
        }
        return count;
    }
}
