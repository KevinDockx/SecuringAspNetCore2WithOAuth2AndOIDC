using Microsoft.EntityFrameworkCore;


namespace ImageGallery.API.Entities
{     
        public class GalleryContext : DbContext
        {
            public GalleryContext(DbContextOptions<GalleryContext> options)
               : base(options)
            {
            }

            public DbSet<Image> Images { get; set; }
        }
}
