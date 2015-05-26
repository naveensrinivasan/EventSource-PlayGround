using System;
using System.IO;
using System.Diagnostics;


namespace EventSourceSamples
{
    public static class AllSamples
    {
        /// <summary>
        /// The samples are 'console based' in that they spew text to an output stream.   By default this is
        /// the Console, but you can redirect it elsewhere by overriding this static variable.  
        /// </summary>
        public static TextWriter Out = Console.Out;

        /// <summary>
        /// This is the main entry point for all the samples.   It runs them sequentially
        /// </summary>
        public static void Run()
        {
                CustomizedEventSourceDemo.Run(); 

        }
    }
}
