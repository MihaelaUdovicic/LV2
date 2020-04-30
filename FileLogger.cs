using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class FileLogger : ILogger
    {

        private string filePath;
        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public void Log(string message)
        {
            if (this.filePath.Equals("File"))
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
                {
                    writer.WriteLine(message);
                }
            else
                throw new ArgumentException("Unkown type");
        }

    }
}

/*
 * //.....................5.Zadatak......................
 * 
 class FileLogger : ILogger
{

    private string filePath;
    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }

    public void Log(ILogable message)
    {
        if (this.type.Equals("File"))
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))

                //writer.WriteLine(
                message.GetStringRepresentation(){ return "radi"; } //);
        }
        else
            throw new ArgumentException("Unkown type");
    }

} */
