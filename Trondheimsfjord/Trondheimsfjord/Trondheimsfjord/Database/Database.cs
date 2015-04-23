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
                    //*** From Vanvikan ***
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 5, 50, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 6, 50, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 55, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 15, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 45, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 30, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 30, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 30, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 21, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 22, 55, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},

                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 6, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 15, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 45, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},

                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 45, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 20, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 22, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 22, 55, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Vanvikan"}, Destination = Destination.Trondheim},

                    //*** From Trondheim ***
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 6, 20, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 20, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 25, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 45, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 15, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 30, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 21, 45, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 23, 30, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},

                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 25, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 25, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 45, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 15, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},

                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 15, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 21, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 22, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Vanvikan},
                };
            }
            if (atbRouteNr == 810)
            {
                return new List<Departure>()
                {
                    //MONDAY - THURSDAY

                    //*** Trondeim - Kristiansund *** (Monday - Thursday)
                    //From Trondheim
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 6, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 7, 20, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 10, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 10, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 15, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 45, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 45, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 30, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 45, 0), ArrivalTime = new DateTime(2015, 1, 1, 19, 45, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 21, 00, 0), ArrivalTime = new DateTime(2015, 1, 1, 22, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},

                    //From Lensvik
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 45, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 5, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 19, 45, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 21, 35, 0), ArrivalTime = new DateTime(2015, 1, 1, 22, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Brekstad},

                    //From Hysnes
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 6, 0), ArrivalTime = new DateTime(2015, 1, 1, 7, 20, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 55, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Kristiansund},

                    //From Brekstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 10, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 10, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 35, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Kristiansund},

                    //From Sandstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 50, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 50, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 15, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 45, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Kristiansund},
                    
                    //From Edøy
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 0, 0), ArrivalTime = new DateTime(2015, 1, 1, 7, 45, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 0, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 0, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 25, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},
                    

                    //*** Kristiansund - Trondheim *** (Monday - Thursday)
                    //From Kristiansund
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 0, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 25, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 0, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 35, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 30, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 20, 30, 0), ArrivalTime = new DateTime(2015, 1, 1, 21, 10, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Edøy},

                    //From Edøy
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 40, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 25, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Edøy"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 40, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 35, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Edøy"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 10, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Edøy"}, Destination = Destination.Trondheim},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 25, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 35, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 50, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Trondheim},

                    //From Sandstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 50, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 25, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 50, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 35, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Trondheim},

                    //From Brekstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 6, 15, 0), ArrivalTime = new DateTime(2015, 1, 1, 7, 15, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 30, 0), ArrivalTime = new DateTime(2015, 1, 1, 8, 35, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 35, 0), ArrivalTime = new DateTime(2015, 1, 1, 11, 25, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 20, 0), ArrivalTime = new DateTime(2015, 1, 1, 12, 10, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 30, 0), ArrivalTime = new DateTime(2015, 1, 1, 15, 35, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 55, 0), ArrivalTime = new DateTime(2015, 1, 1, 16, 55, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 0, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 0, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 20, 0, 0), ArrivalTime = new DateTime(2015, 1, 1, 20, 50, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},

                    //From Hysnes
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 5, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 10, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},

                    //From Lensvik
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 6, 40, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 55, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 55, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Trondheim},


                    //FRIDAY


                    //*** Trondheim - Kristiansund (Friday)
                    //From Trondheim
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 6, 20, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 10, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 20, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 15, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 45, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 30, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 0, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 20, 15, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},

                    //From Lensvik
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 20, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 5, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 20, 50, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Brekstad},

                    //From Hysnes
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 6, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 55, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 45, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Brekstad},

                    //From Brekstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 10, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 10, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 35, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Kristiansund},

                    //From Sandstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 50, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 50, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 15, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 20, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 20, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 45, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Kristiansund},
                    
                    //From Edøy
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 0, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 0, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 0, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 25, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},

                    //*** Kristiansund - Trondheim (Friday)
                    //From Kristiansund
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 0, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 0, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 30, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 20, 30, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Edøy},

                    //From Edøy
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 40, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Edøy"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 40, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Edøy"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 10, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Edøy"}, Destination = Destination.Trondheim},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 20, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 20, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 50, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Trondheim},

                    //From Sandstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 50, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 50, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 20, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Trondheim},

                    //From Brekstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 6, 15, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 30, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 35, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 20, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 30, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 55, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 5, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 0, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},

                    //From Hysnes
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 40, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 40, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 5, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 10, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},

                    //From Lensvik
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 6, 40, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 7, 55, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 55, 0), Weekday = DayOfWeek.Friday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Trondheim},



                    //SATURDAY

                    //*** Trondheim - Kristiansund (Saturday)
                    //From Trondheim
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 40, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 11, 45, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 40, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 21, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},

                    //From Lensvik
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 15, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Kristiansund},

                    //From Hysnes

                    //From Brekstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 40, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Kristiansund},

                    //From Sandstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 50, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 50, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 15, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 20, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Kristiansund},
                    
                    //From Edøy
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 9, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},


                    //*** Kristiansund - Trondheim (Saturday)
                    //From Kristiansund
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Trondheim},

                    //From Ringholmen
                    //Signalanløp
 
                    //From Edøy
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 10, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Edøy"}, Destination = Destination.Trondheim},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 50, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Trondheim},

                    //From Sandstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 10, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Trondheim},

                    //From Brekstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 30, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 40, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 40, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 0, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},

                    //From Hysnes
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 50, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},

                    //From Lensvik
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 8, 55, 0), Weekday = DayOfWeek.Saturday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Trondheim},



                    //SUNDAY

                    //*** Trondheim - Kristiansund (Sunday)
                    //From Trondheim
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 10, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 15, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 20, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 23, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Trondheim"}, Destination = Destination.Brekstad},

                    //From Lensvik
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 50, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Kristiansund},

                    //From Hysnes
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 0, 15, 0), Weekday = DayOfWeek.Monday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Brekstad},

                    //From Brekstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 10, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 17, 20, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Kristiansund},

                    //From Sandstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 50, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 5, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Kristiansund},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 20, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 35, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Kristiansund},
                    
                    //From Edøy
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 15, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 15, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Edøy"}, Destination = Destination.Kristiansund},


                    //*** Kristiansund - Trondheim (Sunday)
                    //From Kristiansund
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 0, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 15, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 20, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Kristiansund"}, Destination = Destination.Edøy},

                    //From Edøy
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 12, 40, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Edøy"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 55, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Edøy"}, Destination = Destination.Trondheim},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 13, 50, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 5, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Kjørsviksbugen"}, Destination = Destination.Trondheim},

                    //From Sandstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 16, 10, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Sandstad"}, Destination = Destination.Trondheim},

                    //From Brekstad
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 14, 30, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 18, 50, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Brekstad"}, Destination = Destination.Trondheim},

                    //From Hysnes
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 10, 40, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Hysnes"}, Destination = Destination.Trondheim},

                    //From Lensvik
                    new Departure {DepartureTime = new DateTime(2015, 1, 1, 19, 10, 0), Weekday = DayOfWeek.Sunday, Port = new Port {Name = "Lensvik"}, Destination = Destination.Trondheim},


                };
            }
            return new List<Departure>();
        } 
    }
}
