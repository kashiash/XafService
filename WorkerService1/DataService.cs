using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XafService.Module.BusinessObjects;

namespace WorkerService1
{
    public class DataService
    {

        public static void InsertData(string text)
        {
            var ConnectionString = @"Integrated Security = SSPI; Pooling = false; Data Source = (localdb)\mssqllocaldb; Initial Catalog = XafService";



            Session _session = new Session() { ConnectionString = ConnectionString };
            using (UnitOfWork unitOfWork = new UnitOfWork(_session.DataLayer))
            {
                var obj = new ObjectClass1(unitOfWork);
                obj.Text = text;
                obj.Date = DateTime.UtcNow;
                obj.Save();
                unitOfWork.CommitChanges();

            }
        }
    }
}
