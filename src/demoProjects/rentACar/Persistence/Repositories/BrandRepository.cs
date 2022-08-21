using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}