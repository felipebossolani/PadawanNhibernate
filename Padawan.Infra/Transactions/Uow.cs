﻿using NHibernate;
using System.Threading.Tasks;

namespace Padawan.Infra.Transactions
{
    public class Uow : IUow
    {
        private readonly ISession _session;
        public Uow(ISession session)
        {
            _session = session;
        }

        public async Task Commit()
        {
          await _session.FlushAsync();
        }

        public void Rollback()
        {
            // Do nothing :)
        }
    }
}
