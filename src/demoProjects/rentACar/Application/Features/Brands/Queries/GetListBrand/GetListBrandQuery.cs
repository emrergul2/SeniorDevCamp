using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Brands.Models;
using Core.Application.Requests;
using MediatR;

namespace Application.Features.Brands.Queries.GetListBrand
{
    public partial class GetListBrandQuery : IRequest<BrandListModel>
    {
        public PageRequest PageRequest { get; set; }
    }
}