using System;


namespace R5T.Capria
{
    /// <summary>
    /// Examples: 'where', 'dotnet'.
    /// </summary>
    public class ExecutableShortCommand : IExecutableCommandPart
    {
        public string Value { get; set; }


        public override string ToString()
        {
            var output = this.Value;
            return output;
        }
    }
}
