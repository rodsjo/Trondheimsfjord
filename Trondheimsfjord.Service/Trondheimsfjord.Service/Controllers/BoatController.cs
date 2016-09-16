using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using Trondheimsfjord.Service.Models;

namespace Trondheimsfjord.Service.Controllers
{
    [EnableCors(origins: "http://localhost:51319/", headers: "*", methods: "*")]
    public class BoatController : ApiController
    {
        private List<Boat> _boats;
        private ScrapingBrowser _scraper;
        private string AISHUB_URL_VESSEL = "http://www.aishub.net/ais-hub-vessel-information.php";

        public BoatController()
        {
            _boats = new List<Boat>
            {
                new Boat(0, "Trondheimsfjord 1", 257304900, 9432177, "LAPA"),
                new Boat(1, "Trondheimsfjord 2", 257114400, 9432189, "LAPB"),
                new Boat(2, "Terningen", 257333000, 9693848, "LGJQ"),
                new Boat(3, "Tyrhaug", 257684700, 9693850, "LGJU"),
                new Boat(4, "Ladejarl", 258177000, 9257448, "LLVI"),
            };

            _scraper = new ScrapingBrowser();
            _scraper.AllowAutoRedirect = true;
            _scraper.AllowMetaRedirect = true;
        }

        // GET: api/Boat
        public IEnumerable<Boat> Get()
        {
            return _boats;
        }

        // GET: api/Boat/id
        public Boat Get(int id)
        {
            var boat = _boats.Find(b => b.Id == id);
            var url = AISHUB_URL_VESSEL + "?mmsi=" + boat.Mmsi;
            var page1 = _scraper.NavigateToPage(new Uri("http://www.google.com"));
            var page = _scraper.NavigateToPage(new Uri(url));

            var latitudeNode = page.Html.CssSelect("tr:nth-of-type(4) td:nth-of-type(4)").First();
            var latitude = latitudeNode.InnerText;

            var longitudeNode = page.Html.CssSelect("tr:nth-of-type(5) td:nth-of-type(4)").First();
            var longitude = longitudeNode.InnerText;
            

            return boat;
        }

        // POST: api/Boat
        public void Post([FromBody]int id, [FromBody]string name, [FromBody]int mmsi, [FromBody]int imo, [FromBody]string callsign)
        {
            var newBoat = new Boat(id, name, mmsi, imo, callsign);
            _boats.Add(newBoat);
        }

        // DELETE: api/Boat/id
        public void Delete(int id)
        {
            _boats.Remove(_boats.Find(b => b.Id == id));
        }
    }
}
