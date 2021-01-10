using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMG.Test.Challenge.Api.Helper;

namespace UMG.Test.Challenge.Api.Models
{
    public class Contract
    {
        public int ContractId { get; set; }
        public int ArtistId { get; set; }
        public int PartnerId { get; set; }
        public int AlbumId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ContractTypeEnum ContractType { get; set; }
    }
}
