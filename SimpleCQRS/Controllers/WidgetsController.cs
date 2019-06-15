using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using SimpleCQRS.Domain.Commands;
using SimpleCQRS.Domain.Commands.Command;
using SimpleCQRS.Domain.Entities;
using SimpleCQRS.Domain.Queries;
using SimpleCQRS.Domain.Queries.Query;

namespace SimpleCQRS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WidgetsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Widget> ListWidgets()
        {
            var query = new AllWidgetQuery();
            var handler = WidgetQueryFactory.Build(query);
            return handler.Get();
        }

        [HttpGet("{widgetId}")]
        public Widget WidgetDetails(int widgetId)
        {
            var query = new SingleWidgetQuery(widgetId);
            var handler = WidgetQueryFactory.Build(query);
            return handler.Get();
        }

        [HttpPost]
        public IActionResult SaveWidget(Widget item)
        {
            var command = new SaveWidgetCommand(item);
            var handler = WidgetCommandFactory.Build(command);
            var response = handler.Execute();
            if (response.IsSuccess)
            {
                item.Id = response.Id;
                return Ok(item);
            }

            return BadRequest(response.Message);
        }
    }
}