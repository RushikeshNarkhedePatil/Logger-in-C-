using System;

namespace logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //create tuple in c#
            var person = Tuple.Create(1, "Steve", "Jobs");
            //access tuple value
            Console.WriteLine(person.Item1);    //1
            Console.WriteLine(person);
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info("App Started {arguments} {username}",args,"fullstackamigo");
            try
            {

            }
            catch(Exception e)
            {
                logger.Error(e, "this is unexpected! {args}", 2);
            }
            NLog.LogManager.Shutdown();
         

        }
    }
}