using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMG.Test.Challenge.Api.Models;
using UMG.Test.Challenge.Api.Models.dto;

namespace UMG.Test.Challenge.Api.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public virtual DbSet<DistributorAlbum> DistributorAlbums { get; set; }
    }
}
