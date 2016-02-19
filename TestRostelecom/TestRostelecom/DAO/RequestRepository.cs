using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRostelecom.DAO
{
    class RequestRepository
    {
        private RequestDatabaseDataContext db = new RequestDatabaseDataContext();

        public Requests GetRequestById(int id)
        {
            return db.Requests.Single(x => x.Id == id);
        }

        public void CreateRequest(Requests request)
        {
            db.Requests.InsertOnSubmit(request);
            db.SubmitChanges();
        }

        public void DeleteRequest(Requests request)
        {
            db.Requests.DeleteOnSubmit(request);
            db.SubmitChanges();
        }

        public void UpdateRequest(Requests request)
        {
            Requests req = db.Requests.Single(x => x.Id == request.Id);
            req.Address = request.Address;
            req.ClientId = request.ClientId;
            req.CloseDate = request.CloseDate;
            req.Comment = request.Comment;
            req.DateOfDeparture = request.DateOfDeparture;
            req.OperatorId = request.OperatorId;
            req.MasterId = request.MasterId;
            req.ServiceId = request.ServiceId;
            db.SubmitChanges();
        }

        public IEnumerable<Requests> GetRequestsByDateTimeFrame(DateTime begin, DateTime end)
        {
            return db.Requests.Where(x => ((x.RequestDate >= begin) && (x.RequestDate <= end)));
        }
    }
}
