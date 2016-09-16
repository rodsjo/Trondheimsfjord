using System.Runtime.Serialization;

namespace Trondheimsfjord.Service.Models
{
    [DataContract]
    public class Boat
    {
        [DataMemberAttribute]
        public string Name { get; private set; }

        [DataMemberAttribute]
        public int Id { get; private set; }

        [DataMemberAttribute]
        public int Mmsi { get; private set; }

        [DataMemberAttribute]
        public int Imo { get; private set; }

        [DataMemberAttribute]
        public double Latitude { get; set; }

        [DataMemberAttribute]
        public double Longitude { get; set; }

        [DataMemberAttribute]
        public double SpeedKmh { get; set; }

        [DataMemberAttribute]
        public int Heading { get; set; }

        [DataMemberAttribute]
        public string Callsign { get; private set; }

        public Boat(int id, string name, int mmsi, int imo, string callsign)
        {
            Id = id;
            Name = name;
            Mmsi = mmsi;
            Imo = imo;
            Callsign = callsign;
        }
    }
}