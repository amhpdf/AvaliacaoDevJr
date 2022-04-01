using AMHP.Avaliacao.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace AMHP.Avaliacao.Site.DatabaseContextSite
{
    public class DatabaseContextSite : IDisposable
    {
        private readonly AvaliacaoContext _avaliacaoContext;

        public void Dispose()
        {
            _avaliacaoContext?.Dispose();
            GC.SuppressFinalize(this);
        }

        public AvaliacaoContext ObterAvaliacaoContext()
        {
            return _avaliacaoContext;
        }

        public DatabaseContextSite()
        {
            
        }
    }
}
