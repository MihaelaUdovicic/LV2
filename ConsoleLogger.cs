using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class ConsoleLogger : ILogger
    {
        private string type;

        public ConsoleLogger(string type)
        {
            this.type = type;
        }
        public void Log(string message)
        {
            if (this.type.Equals("Console"))
                Console.WriteLine(message);
            else
                throw new ArgumentException("Unkown type");
        }
    }
}

/*
 * //...................5.Zadatak..........................
 * 
 class ConsoleLogger : ILogger
{
    private string type;

    public ConsoleLogger(string type)
    {
        this.type = type;
    }
    public void Log(ILogable message)
    {
        if (this.type.Equals("Console"))
            //Console.WriteLine(
            message.GetStringRepresentation(){ return "radi"; } //);
    else
            throw new ArgumentException("Unkown type");
    }
}
 */
