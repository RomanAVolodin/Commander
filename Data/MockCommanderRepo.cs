using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg5555", Line = "Boil water", Platform = "Kettle and pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Boil water2", Platform = "Kettle and pan2" },
                new Command { Id = 2, HowTo = "Make tea", Line = "Place teabag to a cup", Platform = "Kettle and cup" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle and pan" };
        }
    }
}