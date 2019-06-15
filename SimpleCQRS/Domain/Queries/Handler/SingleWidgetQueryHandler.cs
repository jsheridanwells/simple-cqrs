using System.Linq;
using SimpleCQRS.Domain.Entities;
using SimpleCQRS.Domain.Queries.Query;

namespace SimpleCQRS.Domain.Queries.Handler
{
    public class SingleWidgetQueryHandler : IQueryHandler<SingleWidgetQuery, Widget>
    {
        private readonly SingleWidgetQuery _query;

        public SingleWidgetQueryHandler(SingleWidgetQuery query)
        {
            _query = query;
        }
        public Widget Get()
        {
            return MockDb.Widgets.AsQueryable()
                .FirstOrDefault(w => w.Id == _query.Id);
        }
    }
}
