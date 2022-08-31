using Application.Features.Brands.Dtos;
using MediatR;

namespace Application.Features.Brands.Queries.GetByIdBrand;

public partial class GetByIdBrandQuery : IRequest<BrandGetByIdDto>
{
    public int Id { get; set; }
}
