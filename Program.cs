using System;
using System.Threading;

namespace BuildApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
		Console.WriteLine(DateTime.Now.ToString());
                Thread.Sleep(5000);
	    }
        }
    }
}
