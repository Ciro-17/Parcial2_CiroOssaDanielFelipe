using Microsoft.EntityFrameworkCore;
using Parcial2_CiroOssaDanielFelipe.DAL.Entities;

namespace Parcial2_CiroOssaDanielFelipe.DAL
{
    public class DataBaseContext : DbContext 
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options) : base(options)
        {
                
        }

        public DbSet<PersonaNatural> personaNaturals { get; set; }
    }
}
