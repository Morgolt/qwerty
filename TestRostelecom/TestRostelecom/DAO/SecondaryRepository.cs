using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRostelecom.DAO
{

    // TODO: Deside, which methods (lists or dictionaries) we want to use

    public class SecondaryRepository
    {
        private RequestDatabaseDataContext db;

        public SecondaryRepository(RequestDatabaseDataContext context)
        {
            this.db = context;
        }

        public List<Masters> GetMastersList()
        {
            return db.Masters.ToList();
        }

        public List<Services> GetServicesList()
        {
            return db.Services.ToList();
        }

        public List<Operators> GetOperatorsList()
        {
            return db.Operators.ToList();
        }

        public List<Clients> GetClientsList()
        {
            return db.Clients.ToList();
        }

        public Dictionary<int, string> GetMastersDictionary()
        {
            return db.Masters.ToDictionary(x => x.Id, x => x.FullName);
        }

        public Dictionary<int, string> GetServicesDictionary()
        {
            return db.Services.ToDictionary(x => x.Id, x => x.Name);
        }

        public Dictionary<int, string> GetOperatorsDictionary()
        {
            return db.Operators.ToDictionary(x => x.Id, x => x.FullName);
        }

        public Dictionary<int, string> GetClientsDictionary()
        {
            return db.Clients.ToDictionary(x => x.Id, x => x.FullName);
        }

        public void CreateClient(Clients client)
        {
            db.Clients.InsertOnSubmit(client);
            db.SubmitChanges();
        }

        public Clients GetClientByFullName(string fullName)
        {
            return db.Clients.SingleOrDefault(x => x.FullName == fullName);
        }
    }
}
