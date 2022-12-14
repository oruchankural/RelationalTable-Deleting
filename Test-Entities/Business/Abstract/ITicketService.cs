using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test_Entities.Model;

namespace Test_Entities.Business.Abstract
{
    public interface ITicketService : IGenericService<Ticket>
    {
        Task<Ticket> GetTicket(int id, List<Expression<Func<Ticket, IEntity>>> expressionList);
    }
}
