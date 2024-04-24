using MediatR;

namespace MediatrExample.Med.Queries;

public class GetAllProductQuery : IRequest<List<GetProductIdByIdViewModel>>
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductIdByIdViewModel>>
    {
        public Task<List<GetProductIdByIdViewModel>> Handle(GetAllProductQuery request,
            CancellationToken cancellationToken)
        {
            var model = new GetProductIdByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            
            var model2 = new GetProductIdByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Monitor"
            };
            
            return Task.FromResult(new List<GetProductIdByIdViewModel>()
            {
                model, model2
            });
        }
    }
}