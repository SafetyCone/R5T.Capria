using System;


namespace R5T.Capria
{
    public class ExecutableFilePathCommand : IExecutableCommandPart
    {
        public string ExecutableFilePath { get; set; }


        public override string ToString()
        {
            var output = this.ExecutableFilePath;
            return output;
        }
    }
}
