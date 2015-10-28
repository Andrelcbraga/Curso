using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LojaVirtual.Dominio.Entidades;


namespace LojaVirtual.Dominio.Repositorio
{
  public class EFDBContext: DbContext
    {
      public DbSet<Produto> Produtos { get; set; }
    }
}
