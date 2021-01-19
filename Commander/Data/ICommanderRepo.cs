using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllComands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        bool SaveChange();
        void UpdateCommand(Command command);
    }
}
