using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRostelecom.DAO
{
    class Request
    {
        public int Id { get; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime DateOfDeparture { get; set; }
        public DateTime CloseDate { get; set; }

        public Request(int id, string address, string comment, DateTime requestDate, DateTime dateOfDeparture, DateTime closeDate)
        {
            Id = id;
            Address = address;
            Comment = comment;
            RequestDate = requestDate;
            DateOfDeparture = dateOfDeparture;
            CloseDate = closeDate;
        }

    }
}
