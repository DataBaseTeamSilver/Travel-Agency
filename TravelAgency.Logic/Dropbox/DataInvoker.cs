namespace TravelAgency.Logic.Dropbox
{
    using System.Collections.Generic;
    using Data;

    public class DataInvoker
    {
        public IEnumerable<ReportTransport> GetData(TravelAgencyDbContext dbContext, string destination, string guide, string transport)
        {
            DropboxApprover empty = new DataApprover();
            DropboxApprover dest = new DestinationApprover();
            DropboxApprover guides = new GuideApprover();
            DropboxApprover trans = new TransportApprover();
            DropboxApprover all = new AllTypeApprover();

            empty.SetSuccessor(dest);
            dest.SetSuccessor(guides);
            guides.SetSuccessor(trans);
            trans.SetSuccessor(all);
            
            var ex = empty.ProcessRequest(dbContext, destination, guide, transport);
            return ex;
        }
    }
}