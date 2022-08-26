using System;

namespace logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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