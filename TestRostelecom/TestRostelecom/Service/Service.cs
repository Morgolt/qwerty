using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TestRostelecom.DAO;

namespace TestRostelecom.Service
{
    public class Service
    {

        private RequestRepository requestRepo;
        private SecondaryRepository secondaryRepo;
        private RequestDatabaseDataContext requestDBContext;

        public Service()
        {
            requestDBContext = new RequestDatabaseDataContext();
            requestRepo = new RequestRepository(requestDBContext);
            secondaryRepo = new SecondaryRepository(requestDBContext);
        }

        public IList getListMasters()
        {
            return secondaryRepo.GetMastersList();
        }
        public IList getListOperators()
        {
            return secondaryRepo.GetOperatorsList();
        }
        public IList getListServices()
        {
            return secondaryRepo.GetServicesList();
        }
        public string CreateRequest(string clientName, int masterId, int operatorId, int serviceId, string comment,
            string adress, DateTime requestDate, DateTime closeDate, DateTime dateOfDeparture)
        {
            Clients client = new Clients();
            client.FullName = clientName;

            string message;
            this.secondaryRepo.CreateClient(client);
            message = "Заявка добавлена успешно";

            Requests request = new Requests();

            request.ClientId = client.Id;
            request.MasterId = masterId;
            request.OperatorId = operatorId;
            request.ServiceId = serviceId;
            request.Comment = comment;
            request.Address = adress;
            request.RequestDate = requestDate;
            request.CloseDate = closeDate;
            request.DateOfDeparture = dateOfDeparture;

            requestRepo.CreateRequest(request);
            return message;

        }
        public Masters GetMasterExact(int id)
        {
            return secondaryRepo.GetMasterById(id);
        }
        public Operators GetOperatorExact(int id)
        {
            return secondaryRepo.GetOperatorById(id);
        }
        public Services GetServiceExact(int id)
        {
            return secondaryRepo.GetServiceById(id);
        }
        public BindingList<Requests> getDataSource()
        {
            return new BindingList<Requests>(requestDBContext.Requests.ToList());
        }

        public string UpdateRequest(Requests request, string clientName, int masterId, int operatorId, int serviceId, string comment, 
            string adress, DateTime requestDate, DateTime closeDate, DateTime dateOfDeparture)
        {
            Clients client = new Clients();
            client.FullName = clientName;
            request.Clients = secondaryRepo.CreateClient(client);
            request.Masters = GetMasterExact(masterId);
            request.Operators = GetOperatorExact(operatorId);
            request.Services = GetServiceExact(serviceId);
            request.Address = adress;
            request.Comment = comment;
            request.RequestDate = requestDate;
            request.CloseDate = closeDate;
            request.DateOfDeparture = dateOfDeparture;

            requestDBContext.SubmitChanges();
            requestRepo.UpdateRequest(request);

            return "Заявка успешно изменена";

        }
    }
}
