using Factory.Business;
using Factory.Interface;

namespace OMB.Mediator;

public class DashboardManager : IInvoke
{
    public async Task<DTO> Invoke(DTO dto)
    {
        DTO result = new DTO();
        switch (dto.Type)
        {
            case 10:
                result.Data = "Dashboard 1";
                break;
            case 11:
                result.Data = "Dashboard 2";
                break;
        }
        return result;
    }
}
