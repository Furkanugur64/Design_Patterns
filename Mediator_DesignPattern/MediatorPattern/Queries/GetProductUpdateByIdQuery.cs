using Mediator_DesignPattern.MediatorPattern.Results;
using MediatR;

namespace Mediator_DesignPattern.MediatorPattern.Queries
{
    public class GetProductUpdateByIdQuery:IRequest<GetProductUpdateByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductUpdateByIdQuery(int id)
        {
            Id = id;
        }
    }
}
