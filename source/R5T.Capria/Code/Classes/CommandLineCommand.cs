using System;


namespace R5T.Capria
{
    public class CommandLineCommand
    {
        public IExecutableCommandPart Command { get; set; }
        public IArgumentsCommandPart Arguments { get; set; }
    }
}
