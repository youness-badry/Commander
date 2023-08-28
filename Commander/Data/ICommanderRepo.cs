using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
        bool SaveChanges();
        void updateCommand(Command command);
        void DeleteCommand(Command command);
    }
}
