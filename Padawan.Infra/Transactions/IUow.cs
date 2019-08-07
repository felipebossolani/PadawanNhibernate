using System.Threading.Tasks;

namespace Padawan.Infra.Transactions
{
    public interface IUow
    {
        Task Commit();
        void Rollback();            
    }
}
