using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Abhibus.Utilities
{
    internal class BookBusData
    {
        public string? FromInput { get; set; }
        public string? ToInput { get; set; }

        public string? Date { get; set; }
        public string? BusType {  get; set; }
        public string? Departure { get; set; }
        //public string? BusPartner { get; set; }
        public string? ShowSeats { get; set; }
        

        public string? Select { get; set; }

        public string? BP {  get; set; }

        public string? DP { get; set;}
        public string? Continue { get; set; }
        public string? Close { get; set; }
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string? Contact { get; set; }
        public string? Email { get; set; }
        public string? Abhiassured { get; set; }
        public string? TravelIns { get; set; }
        public string? Address { get; set; }
        public string? Pin { get; set; }
        public string? State { get; set;}
        public string? City { get; set; }
        public string? Save { get; set; }
       
        


    }
}
