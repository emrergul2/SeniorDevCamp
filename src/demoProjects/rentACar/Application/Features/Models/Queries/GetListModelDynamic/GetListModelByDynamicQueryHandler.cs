using Application.Features.Models.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Models.Queries.GetListModelDynamic;

public class GetListModelByDynamicQueryHandler : IRequestHandler<GetListModelByDynamicQuery, ModelListModel>
{
    public IMapper _mapper { get; set; }
    public IModelRepository _modelRepository { get; set; }

    public GetListModelByDynamicQueryHandler(IModelRepository modelRepository, IMapper mapper)
    {
        _modelRepository = modelRepository;
        _mapper = mapper;
    }

    public async Task<ModelListModel> Handle(GetListModelByDynamicQuery request, CancellationToken cancellationToken)
    {
        IPaginate<Model> models = await _modelRepository.GetListByDynamicAsync(
            dynamic: request.Dynamic,
            include: m => m.Include(c => c.Brand),
            index: request.PageRequest.Page,
            size: request.PageRequest.PageSize
            );
            
        ModelListModel mappedModels = _mapper.Map<ModelListModel>(models);
        return mappedModels;
    }
}
