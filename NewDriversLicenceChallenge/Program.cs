using System;
using System.Collections.Generic;
using System.Linq;

namespace NewDriversLicenceChallenge
{
    /*
        You show up at the office at the same time as other people. 
		The office says that they will see everyone in alphabetical order 
		and it takes 20 minutes for them to process each new license. 
		All of the agents are available now, and they can each see one customer at a time. 
		How long will it take for you to walk out of the office with your new license?

        Sample Input
        'Eric'  						//name
        2       						//number of agents
        'Adam Caroline Rebecca Frank' 	//other

        Sample Output 
        40

        Explanation 
        It will take 40 minutes to get your license because you are in the second group of 
		two to be seen by one of the two available agents

        Note: it sensitive to first names letter
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre:");
            var name = Console.ReadLine();

            Console.WriteLine("Cantidad de agentes:");
            var agents = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombres de clientes separados por espacio:");
            var totalCustomers = Console.ReadLine();

            string[] allCustomers = (totalCustomers + " " + name).Split(' ');
            allCustomers = allCustomers.OrderBy(c => c).ToArray();

            int index = Array.IndexOf(allCustomers, name);
            int wait = (index / agents + 1) * 20;

            Console.WriteLine("\nNombre: " + name);
            Console.WriteLine("\nAgentes: " + agents);
            Console.WriteLine("\nEspera total: {0}", wait.ToString());


            Console.ReadKey();
        }
    }
}
