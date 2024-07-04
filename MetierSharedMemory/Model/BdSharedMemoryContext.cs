using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using MetierSharedMemory.Utils;

namespace MetierSharedMemory.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class BdSharedMemoryContext:DbContext
    {

        public BdSharedMemoryContext():base("connSharedmemory") { }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Jury> Jurys { get; set; }
        public DbSet<JuryMemoire> JuryMemoires { get; set; }

        public DbSet<Memoire> Memoires { get; set;}

        public DbSet<Td_Erreur> td_Erreurs { get; set; }
    }
}