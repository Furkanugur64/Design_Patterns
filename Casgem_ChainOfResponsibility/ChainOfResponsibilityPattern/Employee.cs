using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainOfResponsibilityPattern
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void setNextApprover(Employee supervisor)
        {
            this.NextApprover = supervisor;
        }


        public abstract void ProcessRequest(CustomerProcessViewModel req);       
        
    }
}
