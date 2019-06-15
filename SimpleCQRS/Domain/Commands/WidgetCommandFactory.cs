using SimpleCQRS.Domain.Commands.Command;
using SimpleCQRS.Domain.Commands.Handler;
using SimpleCQRS.Domain.Entities;

namespace SimpleCQRS.Domain.Commands
{
    public class WidgetCommandFactory
    {
        public static ICommandHandler<SaveWidgetCommand, CommandResponse> Build(SaveWidgetCommand command)
        {
            return new SaveWidgetCommandHandler(command);
        } 
    }
}