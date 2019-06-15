using SimpleCQRS.Domain.Entities;

namespace SimpleCQRS.Domain.Commands.Command
{
    public class SaveWidgetCommand : ICommand<CommandResponse>
    {
        public Widget Widget { get; private set; }

        public SaveWidgetCommand(Widget item)
        {
            Widget = item;
        }
    }
}