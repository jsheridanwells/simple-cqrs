using System.Collections.Generic;
using System.Linq;
using SimpleCQRS.Domain.Entities;
using SimpleCQRS.Domain.Queries.Query;

namespace SimpleCQRS.Domain.Queries.Handler
{
    public class AllWidgetQueryHandler : IQueryHandler<AllWidgetQuery, IEnumerable<Widget>>
    {
        public IEnumerable<Widget> Get()
        {
            return MockDb.Widgets.OfType<Widget>();
        }
    }
}