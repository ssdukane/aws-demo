using Factory.Business;
using System.Threading.Tasks;

namespace Factory.Interface
{
    public interface IInvoke
    {
        Task<DTO> Invoke(DTO dto);
    }
}
