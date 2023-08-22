using MediatR;

namespace Mediator_DesignPattern.MediatorPattern.Commands
{
    public class RemoveProductCommand:IRequest
    {
        public RemoveProductCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }        
    }
}
