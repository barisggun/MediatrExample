using MediatR;

namespace MediatrExample.Med.Queries;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery,GetProductIdByIdViewModel>
{
    public Task<GetProductIdByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var viewModel = new GetProductIdByIdViewModel()
        {
            Id = Guid.NewGuid(),
            Name = "Book"
        };

        return Task.FromResult(viewModel);

        // get product from repository
    }
}