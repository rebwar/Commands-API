using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllComands()
        {
            var commands = new List<Command>
            {
                
                new Command
                {
                    Id = 1,
                HowTo = "Paint a Wall",
                Line = "Get a Bucket and paint it!",
                Platform = "Backet and Brush"
                },
                new Command
                {
                    Id = 2,
                HowTo = "Write a Letter",
                Line = "Get a paper and write something you know that!",
                Platform = "Pen and Paper"
                },

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            var command = new Command
            {

                Id = 1,
                HowTo = "Paint a Wall",
                Line = "Get a Bucket and paint it!",
                Platform = "Backet and Brush"

            };
            return command;
        }

        public bool SaveChange()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
