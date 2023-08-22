using Mediator_DesignPattern.MediatorPattern.Results;
using MediatR;

namespace Mediator_DesignPattern.MediatorPattern.Queries
{
    public class GetProductQuery:IRequest<List<GetProductQueryResult>>
    {

    }
}
