using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commends = new List<Command>
            {
                new Command { Id = 0, HowTo = "How To 0", Line = "Line 0", Platform = "Platform 0" },
                new Command { Id = 1, HowTo = "How To 1", Line = "Line 1", Platform = "Platform 1" },
                new Command { Id = 2, HowTo = "How To 2", Line = "Line 2", Platform = "Platform 2" }
            };
            
            return commends;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "How To", Line = "Line", Platform = "Platform"};
        }
    }
}