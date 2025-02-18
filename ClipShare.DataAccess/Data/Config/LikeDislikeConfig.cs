using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClipShare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClipShare.DataAccess.Data.Config
{
    public class LikeDislikeConfig : IEntityTypeConfiguration<LikeDislike>
    {
        public void Configure(EntityTypeBuilder<LikeDislike> builder)
        {
            //defining the primary key which is a combination of both AppUserId and VideoId
            builder.HasKey(x => new { x.AppUserId, x.VideoId });
            builder.HasOne(a => a.AppUser).WithMany(c => c.LikeDislikes).HasForeignKey(a => a.AppUserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(a => a.Video).WithMany(c => c.LikeDislikes).HasForeignKey(a => a.VideoId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
