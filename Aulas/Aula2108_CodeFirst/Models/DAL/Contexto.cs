using System.Data.Entity;

namespace Aula2108_CodeFirst.Models.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("nomeStringConexao")
        {

        }
    }
}
