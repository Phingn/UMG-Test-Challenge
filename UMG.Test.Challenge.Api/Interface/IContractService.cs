using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMG.Test.Challenge.Api.Models.dto;

namespace UMG.Test.Challenge.Api.Interface
{
    public interface IContractService
    {
        Task<List<DistributorAlbum>> GetAlbums(string partnerName, DateTime StartDate, DateTime EndDate);
    }
}
