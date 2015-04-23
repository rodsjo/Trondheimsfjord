using System;
using System.Collections.Generic;
using System.Linq;
using Trondheimsfjord.Models;

namespace Trondheimsfjord.Database
{
    public class Database
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
                new FavoriteRoute {AtBRouteNr = 810, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                new FavoriteRoute {AtBRouteNr = 800, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                new FavoriteRoute {AtBRouteNr = 800, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                new FavoriteRoute {AtBRouteNr = 800, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},
                new FavoriteRoute {AtBRouteNr = 800, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
            };
        }

        public static IEnumerable<Departure> GetDepartures(int atbRouteNr)
        {
            if (atbRouteNr == 810)
            {
                return new List<Departure>
                {
                    //*** From Vanvikan ***
                    new Departure {DepartureTime = new TimeSpan(5, 50, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(6, 50, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(7, 55, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(9, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(10, 15, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(11, 45, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(13, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(15, 30, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(16, 30, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(17, 30, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(19, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(21, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(22, 55, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},

                    new Departure {DepartureTime = new TimeSpan(6, 30, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(8, 0, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(9, 0, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(10, 15, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(11, 45, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(13, 30, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(16, 0, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(17, 30, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},

                    new Departure {DepartureTime = new TimeSpan(10, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(12, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(14, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(16, 45, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(18, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(20, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(22, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(22, 55, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Vanvikan"}, To = new Port {Name = "Trondheim"}},

                    //*** From Trondheim ***
                    new Departure {DepartureTime = new TimeSpan(6, 20, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(7, 20, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(8, 25, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(9, 45, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(11, 15, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(12, 30, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(15, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(16, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(17, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(18, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(21, 45, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(23, 30, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},

                    new Departure {DepartureTime = new TimeSpan(7, 25, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(8, 25, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(9, 45, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(11, 15, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(13, 0, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(15, 30, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(17, 0, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(18, 0, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},

                    new Departure {DepartureTime = new TimeSpan(9, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(11, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(13, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(16, 15, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(18, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(19, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(21, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                    new Departure {DepartureTime = new TimeSpan(22, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Vanvikan"}},
                };
            }
            if (atbRouteNr == 800)
            {
                return new List<Departure>()
                {
                    //MONDAY - THURSDAY

                    //*** Trondeim - Kristiansund *** (Monday - Thursday)
                    //From Trondheim
                    new Departure {DepartureTime = new TimeSpan(6, 20, 0), ArrivalTime = new TimeSpan(7, 20, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(8, 10, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(10, 20, 0), ArrivalTime = new TimeSpan(11, 10, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(12, 15, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(14, 45, 0), ArrivalTime = new TimeSpan(15, 45, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(16, 30, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(18, 45, 0), ArrivalTime = new TimeSpan(19, 45, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(21, 00, 0), ArrivalTime = new TimeSpan(22, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},

                    //From Lensvik
                    new Departure {DepartureTime = new TimeSpan(15, 20, 0), ArrivalTime = new TimeSpan(15, 45, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(17, 5, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(19, 20, 0), ArrivalTime = new TimeSpan(19, 45, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(21, 35, 0), ArrivalTime = new TimeSpan(22, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Brekstad"}},

                    //From Hysnes
                    new Departure {DepartureTime = new TimeSpan(7, 6, 0), ArrivalTime = new TimeSpan(7, 20, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(8, 55, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Kristiansund"}},

                    //From Brekstad
                    new Departure {DepartureTime = new TimeSpan(9, 10, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(13, 10, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(17, 35, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Kristiansund"}},

                    //From Sandstad
                    new Departure {DepartureTime = new TimeSpan(9, 50, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(13, 50, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(18, 15, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Kristiansund"}},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new TimeSpan(10, 20, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(14, 20, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(18, 45, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
                    
                    //From Edøy
                    new Departure {DepartureTime = new TimeSpan(7, 0, 0), ArrivalTime = new TimeSpan(7, 45, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(11, 0, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(15, 0, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(19, 25, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},
                    

                    //*** Kristiansund - Trondheim *** (Monday - Thursday)
                    //From Kristiansund
                    new Departure {DepartureTime = new TimeSpan(8, 0, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(12, 0, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(16, 30, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(20, 30, 0), ArrivalTime = new TimeSpan(21, 10, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Edøy"}},

                    //From Edøy
                    new Departure {DepartureTime = new TimeSpan(8, 40, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(12, 40, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(17, 10, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Trondheim"}},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new TimeSpan(9, 20, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(13, 20, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(17, 50, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Trondheim"}},

                    //From Sandstad
                    new Departure {DepartureTime = new TimeSpan(9, 50, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(13, 50, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(18, 20, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Trondheim"}},

                    //From Brekstad
                    new Departure {DepartureTime = new TimeSpan(6, 15, 0), ArrivalTime = new TimeSpan(7, 15, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(7, 30, 0), ArrivalTime = new TimeSpan(8, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(10, 35, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(11, 20, 0), ArrivalTime = new TimeSpan(12, 10, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(14, 30, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(15, 55, 0), ArrivalTime = new TimeSpan(16, 55, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(19, 0, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(20, 0, 0), ArrivalTime = new TimeSpan(20, 50, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},

                    //From Hysnes
                    new Departure {DepartureTime = new TimeSpan(7, 40, 0), ArrivalTime = new TimeSpan(8, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(14, 40, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(16, 5, 0), ArrivalTime = new TimeSpan(16, 55, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(19, 10, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},

                    //From Lensvik
                    new Departure {DepartureTime = new TimeSpan(6, 40, 0), ArrivalTime = new TimeSpan(7, 15, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(7, 55, 0), ArrivalTime = new TimeSpan(8, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(14, 55, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Trondheim"}},


                    //FRIDAY


                    //*** Trondheim - Kristiansund (Friday)
                    //From Trondheim
                    new Departure {DepartureTime = new TimeSpan(6, 20, 0), ArrivalTime = new TimeSpan(7, 20, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(8, 10, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(10, 20, 0), ArrivalTime = new TimeSpan(11, 10, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(12, 15, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(14, 45, 0), ArrivalTime = new TimeSpan(15, 45, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(16, 30, 0), ArrivalTime = new TimeSpan(20, 0, 0),Weekday = DayOfWeek.Friday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(17, 0, 0), ArrivalTime = new TimeSpan(18, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(20, 15, 0), ArrivalTime = new TimeSpan(21, 15, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},

                    //From Lensvik
                    new Departure {DepartureTime = new TimeSpan(15, 20, 0), ArrivalTime = new TimeSpan(15, 45, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(17, 5, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(20, 50, 0), ArrivalTime = new TimeSpan(21, 15, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Brekstad"}},

                    //From Hysnes
                    new Departure {DepartureTime = new TimeSpan(7, 6, 0), ArrivalTime = new TimeSpan(7, 20, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(8, 55, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(17, 45, 0), ArrivalTime = new TimeSpan(18, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Brekstad"}},

                    //From Brekstad
                    new Departure {DepartureTime = new TimeSpan(9, 10, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(13, 10, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(17, 35, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Kristiansund"}},

                    //From Sandstad
                    new Departure {DepartureTime = new TimeSpan(9, 50, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(13, 50, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(18, 15, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Kristiansund"}},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new TimeSpan(10, 20, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(14, 20, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(18, 45, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
                    
                    //From Edøy
                    new Departure {DepartureTime = new TimeSpan(7, 0, 0), ArrivalTime = new TimeSpan(7, 45, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(11, 0, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(15, 0, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(19, 25, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},

                    //*** Kristiansund - Trondheim (Friday)
                    //From Kristiansund
                    new Departure {DepartureTime = new TimeSpan(8, 0, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(12, 0, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(16, 30, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(20, 30, 0), ArrivalTime = new TimeSpan(21, 10, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Edøy"}},

                    //From Edøy
                    new Departure {DepartureTime = new TimeSpan(8, 40, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(12, 40, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(17, 10, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Trondheim"}},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new TimeSpan(9, 20, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(13, 20, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(17, 50, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Trondheim"}},

                    //From Sandstad
                    new Departure {DepartureTime = new TimeSpan(9, 50, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(13, 50, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(18, 20, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Trondheim"}},

                    //From Brekstad
                    new Departure {DepartureTime = new TimeSpan(6, 15, 0), ArrivalTime = new TimeSpan(7, 15, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(7, 30, 0), ArrivalTime = new TimeSpan(8, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(10, 35, 0), ArrivalTime = new TimeSpan(11, 25, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(11, 20, 0), ArrivalTime = new TimeSpan(12, 10, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(14, 30, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(15, 55, 0), ArrivalTime = new TimeSpan(16, 55, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(18, 5, 0), ArrivalTime = new TimeSpan(18, 55, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(19, 0, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},

                    //From Hysnes
                    new Departure {DepartureTime = new TimeSpan(7, 40, 0), ArrivalTime = new TimeSpan(8, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(14, 40, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(16, 5, 0), ArrivalTime = new TimeSpan(16, 55, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(19, 10, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},

                    //From Lensvik
                    new Departure {DepartureTime = new TimeSpan(6, 40, 0), ArrivalTime = new TimeSpan(7, 15, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(7, 55, 0), ArrivalTime = new TimeSpan(8, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(14, 55, 0), ArrivalTime = new TimeSpan(15, 35, 0), Weekday = DayOfWeek.Friday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Trondheim"}},



                    //SATURDAY

                    //*** Trondheim - Kristiansund (Saturday)
                    //From Trondheim
                    new Departure {DepartureTime = new TimeSpan(9, 40, 0), ArrivalTime = new TimeSpan(10, 30, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(11, 45, 0), ArrivalTime = new TimeSpan(12, 35, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(14, 40, 0), ArrivalTime = new TimeSpan(18, 10, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(21, 30, 0), ArrivalTime = new TimeSpan(22, 20, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},

                    //From Lensvik
                    new Departure {DepartureTime = new TimeSpan(15, 15, 0), ArrivalTime = new TimeSpan(18, 10, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Kristiansund"}},

                    //From Brekstad
                    new Departure {DepartureTime = new TimeSpan(15, 40, 0), ArrivalTime = new TimeSpan(18, 10, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Kristiansund"}},

                    //From Sandstad
                    new Departure {DepartureTime = new TimeSpan(16, 20, 0), ArrivalTime = new TimeSpan(18, 10, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Kristiansund"}},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new TimeSpan(16, 50, 0), ArrivalTime = new TimeSpan(18, 10, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
                    
                    //From Edøy
                    new Departure {DepartureTime = new TimeSpan(9, 0, 0), ArrivalTime = new TimeSpan(9, 45, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(17, 30, 0), ArrivalTime = new TimeSpan(18, 10, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},


                    //*** Kristiansund - Trondheim (Saturday)
                    //From Kristiansund
                    new Departure {DepartureTime = new TimeSpan(14, 30, 0), ArrivalTime = new TimeSpan(17, 50, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Trondheim"}},

                    //From Edøy
                    new Departure {DepartureTime = new TimeSpan(15, 10, 0), ArrivalTime = new TimeSpan(17, 50, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Trondheim"}},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new TimeSpan(15, 50, 0), ArrivalTime = new TimeSpan(17, 50, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Trondheim"}},

                    //From Sandstad
                    new Departure {DepartureTime = new TimeSpan(16, 10, 0), ArrivalTime = new TimeSpan(17, 50, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Trondheim"}},

                    //From Brekstad
                    new Departure {DepartureTime = new TimeSpan(8, 30, 0), ArrivalTime = new TimeSpan(9, 30, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(10, 40, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(12, 40, 0), ArrivalTime = new TimeSpan(13, 30, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(17, 0, 0), ArrivalTime = new TimeSpan(17, 50, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},

                    //From Hysnes
                    new Departure {DepartureTime = new TimeSpan(10, 50, 0), ArrivalTime = new TimeSpan(11, 40, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},

                    //From Lensvik
                    new Departure {DepartureTime = new TimeSpan(8, 55, 0), ArrivalTime = new TimeSpan(9, 30, 0), Weekday = DayOfWeek.Saturday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Trondheim"}},



                    //SUNDAY

                    //*** Trondheim - Kristiansund (Sunday)
                    //From Trondheim
                    new Departure {DepartureTime = new TimeSpan(12, 10, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(16, 15, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(20, 30, 0), ArrivalTime = new TimeSpan(21, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},
                    new Departure {DepartureTime = new TimeSpan(23, 30, 0), ArrivalTime = new TimeSpan(0, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Trondheim"}, To = new Port {Name = "Brekstad"}},

                    //From Lensvik
                    new Departure {DepartureTime = new TimeSpan(16, 50, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Kristiansund"}},

                    //From Hysnes
                    new Departure {DepartureTime = new TimeSpan(0, 15, 0), ArrivalTime = new TimeSpan(0, 30, 0), Weekday = DayOfWeek.Monday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Brekstad"}},

                    //From Brekstad
                    new Departure {DepartureTime = new TimeSpan(13, 10, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(17, 20, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Kristiansund"}},

                    //From Sandstad
                    new Departure {DepartureTime = new TimeSpan(13, 50, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(18, 5, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Kristiansund"}},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new TimeSpan(14, 20, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(18, 35, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Kristiansund"}},
                    
                    //From Edøy
                    new Departure {DepartureTime = new TimeSpan(15, 0, 0), ArrivalTime = new TimeSpan(15, 40, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},
                    new Departure {DepartureTime = new TimeSpan(19, 15, 0), ArrivalTime = new TimeSpan(20, 0, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Kristiansund"}},


                    //*** Kristiansund - Trondheim (Sunday)
                    //From Kristiansund
                    new Departure {DepartureTime = new TimeSpan(12, 0, 0), ArrivalTime = new TimeSpan(15, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(16, 15, 0), ArrivalTime = new TimeSpan(19, 50, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(20, 30, 0), ArrivalTime = new TimeSpan(21, 10, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Kristiansund"}, To = new Port {Name = "Edøy"}},

                    //From Edøy
                    new Departure {DepartureTime = new TimeSpan(12, 40, 0), ArrivalTime = new TimeSpan(15, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(16, 55, 0), ArrivalTime = new TimeSpan(19, 50, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Edøy"}, To = new Port {Name = "Trondheim"}},
                    
                    //From Kjørsviksbugen
                    new Departure {DepartureTime = new TimeSpan(13, 50, 0), ArrivalTime = new TimeSpan(15, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(18, 5, 0), ArrivalTime = new TimeSpan(19, 50, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Kjørsviksbugen"}, To = new Port {Name = "Trondheim"}},

                    //From Sandstad
                    new Departure {DepartureTime = new TimeSpan(13, 50, 0), ArrivalTime = new TimeSpan(15, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(18, 5, 0), ArrivalTime = new TimeSpan(19, 50, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Sandstad"}, To = new Port {Name = "Trondheim"}},

                    //From Brekstad
                    new Departure {DepartureTime = new TimeSpan(10, 30, 0), ArrivalTime = new TimeSpan(11, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(14, 30, 0), ArrivalTime = new TimeSpan(15, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},
                    new Departure {DepartureTime = new TimeSpan(18, 50, 0), ArrivalTime = new TimeSpan(19, 50, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Brekstad"}, To = new Port {Name = "Trondheim"}},

                    //From Hysnes
                    new Departure {DepartureTime = new TimeSpan(10, 40, 0), ArrivalTime = new TimeSpan(11, 30, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Hysnes"}, To = new Port {Name = "Trondheim"}},

                    //From Lensvik
                    new Departure {DepartureTime = new TimeSpan(19, 10, 0), ArrivalTime = new TimeSpan(19, 50, 0), Weekday = DayOfWeek.Sunday, From = new Port {Name = "Lensvik"}, To = new Port {Name = "Trondheim"}},


                };
            }
            return new List<Departure>();
        }

        public static IEnumerable<Departure> GetDepartures(int atbRouteNr, string port)
        {
            return GetDepartures(atbRouteNr).Where(d => d.From.Name.ToLower() == port.ToLower());
        }

        public static IEnumerable<Departure> GetDepartures(int atbRouteNr, string fromPort, string toPort)
        {
            return GetDepartures(atbRouteNr, fromPort).Where(d => d.To.Name.ToLower() == toPort.ToLower());
        }

        public static IEnumerable<Departure> GetDepartures(int atbRouteNr, string fromPort, string toPort, DayOfWeek weekDay)
        {
            if (atbRouteNr == 810)
            {
                if ((weekDay == DayOfWeek.Monday) ||
                    (weekDay == DayOfWeek.Saturday) ||
                    (weekDay == DayOfWeek.Sunday))
                {
                    return GetDepartures(atbRouteNr, fromPort, toPort).Where(d => d.Weekday == weekDay);
                }
                //If Tuesday, Wednesday, Thursday or Friday; use Monday-departures
                return GetDepartures(atbRouteNr, fromPort, toPort).Where(d => d.Weekday == DayOfWeek.Monday);
            }
            if (atbRouteNr == 800)
            {
                if ((weekDay == DayOfWeek.Monday) ||
                    (weekDay == DayOfWeek.Friday) ||
                    (weekDay == DayOfWeek.Saturday) ||
                    (weekDay == DayOfWeek.Sunday))
                {
                    return GetDepartures(atbRouteNr, fromPort, toPort).Where(d => d.Weekday == weekDay);
                }
                //If Tuesday, Wednesday or Thursday; use Monday-departures
                return GetDepartures(atbRouteNr, fromPort, toPort).Where(d => d.Weekday == DayOfWeek.Monday);
            }
            return GetDepartures(atbRouteNr, fromPort, toPort).Where(d => d.Weekday == weekDay);
        }

        public static Departure GetNextDeparture(int atbRouteNr, string fromPort, string toPort, DayOfWeek weekday, TimeSpan time)
        {
            var departures = GetDepartures(atbRouteNr, fromPort, toPort, weekday).ToList();
            if (!departures.Any())
                return null;

            departures.Sort((a, b) => a.DepartureTime.CompareTo(b.DepartureTime));
            var nextDeparture = departures.Find(d => d.DepartureTime > time);

            //Did not find any next departure for the wanted weekday, return first departure next weekday
            if (nextDeparture == null)
            {
                var weekdays = new List<DayOfWeek>()
                {
                    DayOfWeek.Monday,
                    DayOfWeek.Tuesday,
                    DayOfWeek.Wednesday,
                    DayOfWeek.Thursday,
                    DayOfWeek.Friday,
                    DayOfWeek.Saturday,
                    DayOfWeek.Sunday
                };
                for (var i = 0; i < weekdays.Count; i++)
                {
                    if (weekday == weekdays[i])
                    {
                        var nextDay = i + 1;
                        if (nextDay == weekdays.Count) //If Sunday, check departures on Monday
                            nextDay = 0;

                        var nextDayDepartures = GetDepartures(atbRouteNr, fromPort, toPort, weekdays[nextDay]).ToList();
                        if (nextDayDepartures.Any())
                        {
                            nextDayDepartures.Sort((a, b) => a.DepartureTime.CompareTo(b.DepartureTime));
                            return nextDayDepartures.First();
                        }
                        return null;
                    }
                }
            }
            return nextDeparture;
        }

        public static Departure GetNextDeparture(int atbRouteNr, string fromPort, string toPort)
        {
            var nextDeparture = GetNextDeparture(atbRouteNr, fromPort, toPort, DateTime.Now.DayOfWeek, new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0));
            return nextDeparture;
        }
    }
}
