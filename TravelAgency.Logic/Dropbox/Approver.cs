using System.Collections.Generic;
using TravelAgency.Data;

namespace TravelAgency.Logic.Dropbox
{
    internal abstract class DropboxApprover
    {
        protected DropboxApprover Successor { get; set; }

        public void SetSuccessor(DropboxApprover successor)
        {
            this.Successor = successor;
        }

        public abstract IEnumerable<ReportTransport> ProcessRequest(TravelAgencyDbContext dbContext, string destination, string guide, string transport);
    }
}