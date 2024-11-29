using System;

namespace PriuConsole
{
    public class ConsoleCommandAttribute : Attribute
    {
        public string CommandName { get; }

        public ConsoleCommandAttribute(string commandName)
        {
            CommandName = commandName;
        }
    }

}

