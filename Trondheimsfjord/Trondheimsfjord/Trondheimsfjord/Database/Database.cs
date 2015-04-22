using System;
using System.Collections.Generic;
using Trondheimsfjord.Models;

namespace Trondheimsfjord.Database
{
    internal class Database
    {
        public static IList<Port> GetPorts()
        {
            return new List<Port>
            {
                new Port {Name = "Trondheim"},
                new Port {Name = "Vanvikan"},
                new Port {Name = "Lensvik"},
                new Port {Name = "Hysnes"},
                new Port {Name = "Brekstad"},
                new Port {Name = "Sandstad"},
                new Port {Name = "Kjørsviksbugen"},
                new Port {Name = "Edøy"},
                new Port {Name = "Ringholmen"},
                new Port {Name = "Kristiansund"}
            };
        }

        public static IList<Port> GetPorts(int atbRouteNr)
        {
            if (atbRouteNr == 810)
            {
                return new List<Port>
                {
                    new Port {Name = "Trondheim"},
                    new Port {Name = "Vanvikan"},
                };
            }
            if (atbRouteNr == 800)
            {
                return new List<Port>
                {
                    new Port {Name = "Trondheim"},
                    new Port {Name = "Lensvik"},
                    new Port {Name = "Hysnes"},
                    new Port {Name = "Brekstad"},
                    new Port {Name = "Sandstad"},
                    new Port {Name = "Kjørsviksbugen"},
                    new Port {Name = "Edøy"},
                    new Port {Name = "Ringholmen"},
                    new Port {Name = "Kristiansund"}
                };
            }
            return new List<Port>();
        }

        public static IList<Route> GetRoutes()
        {
            return new List<Route>
            {
                new Route {Name = "Trondheim - Vanvikan", AtBRouteNr = 810},
                new Route {Name = "Trondheim - Brekstad - Kristiansund", AtBRouteNr = 800}
            };
        }

        public static IList<FavoriteRoute> GetFavoriteRoutes()
        {
            return new List<FavoriteRoute>
            {
                new FavoriteRoute {From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                new FavoriteRoute {From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                new FavoriteRoute {From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristansund"}},
                new FavoriteRoute {From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},
                new FavoriteRoute {From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
            };
        }

        public static IList<Departure> GetRouteTable(int atbRouteNr)
        {
            if (atbRouteNr == 800)
            {
                return new List<Departure>
                {
                    new Departure {Time = new DateTime(2015, 1, 1, 5, 50, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 6, 50, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 7, 55, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 9, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 10, 15, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 11, 45, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 13, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 15, 30, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 16, 30, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 17, 30, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 19, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 21, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 22, 55, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}},

                    new Departure {Time = new DateTime(2015, 1, 1, 6, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 8, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 9, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 10, 15, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 11, 45, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 13, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 16, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 17, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}},

                    new Departure {Time = new DateTime(2015, 1, 1, 10, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 12, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 14, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 16, 45, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 18, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 20, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 22, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}},
                    new Departure {Time = new DateTime(2015, 1, 1, 22, 55, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}},
                };
            }
            if (atbRouteNr == 810)
            {
                return new List<Departure>();
            }
            return new List<Departure>();
        } 
    }
}
