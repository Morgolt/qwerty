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

        public Request GetRequestById(int id)
        {
            return db.Request.Single(x => x.Id == id);
        }

        public void CreateRequest(Request request)
        {
            db.Request.InsertOnSubmit(request);
            db.SubmitChanges();
        }

        public void DeleteRequest(Request request)
        {
            db.Request.DeleteOnSubmit(request);
            db.SubmitChanges();
        }

        public void UpdateRequest(Request request)
        {
            Request req = db.Request.Single(x => x.Id == request.Id);
            req.Address = request.Address;
            req.ClientId = request.ClientId;
            req.CloseDate = request.CloseDate;
            req.Comment = request.Comment;
            req.DateOfDeparture = request.DateOfDeparture;
            req.OperatorId = request.OperatorId;
            db.SubmitChanges();
        }
    }
}
