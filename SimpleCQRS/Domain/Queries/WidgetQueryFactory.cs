using System.Collections.Generic;
using SimpleCQRS.Domain.Entities;
using SimpleCQRS.Domain.Queries.Handler;
using SimpleCQRS.Domain.Queries.Query;

namespace SimpleCQRS.Domain.Queries
{
    public static class WidgetQueryFactory
    {
        public static IQueryHandler<AllWidgetQuery, IEnumerable<Widget>> Build(AllWidgetQuery query)
        {
            return new AllWidgetQueryHandler();
        }

        public static IQueryHandler<SingleWidgetQuery, Widget> Build(SingleWidgetQuery query)
        {
            return new SingleWidgetQueryHandler(query);
        }
    }
}