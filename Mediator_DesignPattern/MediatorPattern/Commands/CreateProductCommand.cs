using MediatR;

namespace Mediator_DesignPattern.MediatorPattern.Commands
{
    public class CreateProductCommand:IRequest
    {
        public string Name { get; set; }   
        public int Stock { get; set; }
    }
}
