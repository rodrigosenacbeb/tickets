using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = { "580624", "560140", "560137", "560101", "631497", "560133" };
            bool ticketValido;

            while (true)
            {
                Console.WriteLine("Sistema de Validação de Tickets");
                Console.WriteLine();
                Console.Write("Informe o ticket: ");
                string ticket = Console.ReadLine();
                ticketValido = false;

                for (int item = 0; item < tickets.Length; item++)
                {
                    if (tickets[item] == ticket)
                    {
                        ticketValido = true;
                        tickets[item] = null;
                        break;
                    }
                }

                if (ticketValido)
                    Console.WriteLine("Ticket Válido. Entrada Liberada!");
                else
                    Console.WriteLine("Ticket Inválido. Entrada Bloqueada!");

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
