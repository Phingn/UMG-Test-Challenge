using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMG.Test.Challenge.Api.Data;
using UMG.Test.Challenge.Api.Interface;
using UMG.Test.Challenge.Api.Models.dto;

namespace UMG.Test.Challenge.Api.Services
{
    public class ContractService : IContractService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ContractService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<DistributorAlbum>> GetAlbums(string partnerName, DateTime StartDate, DateTime EndDate)
        {
            return await _context.DistributorAlbums
                .Where(x => x.PartnerName.ToString().ToLower() == partnerName.ToLower()
                    && x.Contracts.StartDate >= StartDate && x.Contracts.EndDate <= EndDate)
                .ProjectTo<DistributorAlbum>(_mapper.ConfigurationProvider)
                .ToListAsync();

        }
    }
}
