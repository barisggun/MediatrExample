using MediatR;
using MediatrExample.Entities;

namespace MediatrExample.Med.Queries;

public class GetProductByIdQuery : IRequest<GetProductIdByIdViewModel>
{
    public Guid Id { get; set; }
    
}