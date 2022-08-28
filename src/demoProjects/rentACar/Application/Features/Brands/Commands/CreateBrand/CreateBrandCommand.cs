using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Brands.Dtos;
using Application.Features.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.CreateBrand
{
    public partial class CreateBrandCommand : IRequest<CreatedBrandDto>
    {
        public string Name { get; set; }
    }
}