using System.Collections;
using System.Collections.Generic;
using SimpleCQRS.Domain.Entities;

namespace SimpleCQRS.Domain
{
    public static class MockDb
    {
        public static List<Widget> Widgets { get; }
        public static int UniqueWidgetId = 4;
        static MockDb()
        {
            Widgets = new List<Widget>
            {
                new Widget {Id = 1, Name = "first widget", Shape = "funny"},
                new Widget {Id = 2, Name = "second widget", Shape = "normal"},
                new Widget {Id = 3, Name = "third widget", Shape = "almost hilarious"}
            };
        }
    }
}