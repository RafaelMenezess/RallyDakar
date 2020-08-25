using RallyDakar.Dominio.DbContexto;
using RallyDakar.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RallyDakar.Dominio.Repositorios
{
    public class PilotoRepositorio
    {
        private readonly RallyDbContexto _rallyDbContexto;

        public PilotoRepositorio ( RallyDbContexto rallyDbContexto)
        {
            _rallyDbContexto = rallyDbContexto;
        }
        public void AdicionarPiloto(Piloto piloto)
        {
            _rallyDbContexto.Pilotos.Add(piloto);
            _rallyDbContexto.SaveChanges();
        }
        public IEnumerable<Piloto> obterTodosPilotos()
        {
            return _rallyDbContexto.Pilotos.ToList();
        }
        public IEnumerable<Piloto> ObterTodosPilotos(string nome)
        {
            return _rallyDbContexto.Pilotos
                .Where(p => p.Nome.Contains(nome))
                .ToList();
        }
    }
}
