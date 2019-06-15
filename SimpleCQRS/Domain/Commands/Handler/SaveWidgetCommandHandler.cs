using System;
using System.Linq;
using Microsoft.AspNetCore.Razor.Language;
using SimpleCQRS.Domain.Commands.Command;
using SimpleCQRS.Domain.Entities;

namespace SimpleCQRS.Domain.Commands.Handler
{
    public class SaveWidgetCommandHandler : ICommandHandler<SaveWidgetCommand, CommandResponse>
    {
        private readonly SaveWidgetCommand _command;

        public SaveWidgetCommandHandler(SaveWidgetCommand command)
        {
            _command = command;
        }
        public CommandResponse Execute()
        {
            var response = new CommandResponse() {IsSuccess = false};

            try
            {
                Widget item = MockDb.Widgets
                    .FirstOrDefault(w => w.Id == _command.Widget.Id);
                if (item == null)
                {
                    item = new Widget();
                    item.Id = MockDb.UniqueWidgetId;
                    item.Name = _command.Widget.Name;
                    item.Shape = _command.Widget.Shape;
                    MockDb.UniqueWidgetId++;
                    MockDb.Widgets.Add(item);
                }
                else
                {
                    item.Name = _command.Widget.Name;
                    item.Shape = _command.Widget.Shape;
                }

                response.Id = item.Id;
                response.IsSuccess = true;
                response.Message = $"Widget { item.Name } was saved.";
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }
    }
}