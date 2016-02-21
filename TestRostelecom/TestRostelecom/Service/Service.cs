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
        //test case public
        public RequestRepository requestRepo;
        public SecondaryRepository secondaryRepo;
        public RequestDatabaseDataContext requestDBContext;

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
            if (this.secondaryRepo.GetClientByFullName(clientName) == null)
            {
                this.secondaryRepo.CreateClient(client);
                //client=this.secondaryRepo.GetClientByFullName(clientName);
                message = "Клиент добавлен и заявка создана";
            }
            else
            {
                message = "Заявка добавлена успешно";
            }

            Requests request = new Requests();

            request.ClientId = this.secondaryRepo.GetClientByFullName(clientName).Id;
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
        public Clients GetClientExact(string fullName)
        {
            Clients client = secondaryRepo.GetClientByFullName(fullName);
            if (client != null)
            {
                return secondaryRepo.GetClientById(client.Id);
            }
            else
            {
                return new Clients();
            }
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
            request.Clients = GetClientExact(clientName);
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
        public IEnumerable<Requests> GetRequestsByDateTimeFrame(DateTime begin, DateTime end)
        {
            return requestRepo.GetRequestsByDateTimeFrame(begin, end);
        }
    }
}
