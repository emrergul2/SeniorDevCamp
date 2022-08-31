using Application.Features.Brands.Models;
using Application.Features.Services.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetListBrand
{
    public partial class GetListBrandQuery
    {
        public class GetListQueryHandler : IRequestHandler<GetListBrandQuery, BrandListModel>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetListQueryHandler(IMapper mapper, IBrandRepository brandRepository)
            {
                _mapper = mapper;
                _brandRepository = brandRepository;
            }

            public async Task<BrandListModel> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Brand> brands = await _brandRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                BrandListModel mappedBrandListModel = _mapper.Map<BrandListModel>(brands);
                return mappedBrandListModel;

            }
        }
    }
}