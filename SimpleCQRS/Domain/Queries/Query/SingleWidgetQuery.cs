using SimpleCQRS.Domain.Entities;

namespace SimpleCQRS.Domain.Queries.Query
{
    public class SingleWidgetQuery : IQuery<Widget>
    {
        public int Id { get; private set; }

        public SingleWidgetQuery(int id)
        {
            Id = id;
        }
    }
}