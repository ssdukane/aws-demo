using Factory.Business;
using Factory.Interface;
using Microsoft.AspNetCore.Mvc;

namespace OMB.Mediator;

public class UserManager : IInvoke
{

    [HttpPost]
    [Route("Invoke")]
    public Task<DTO> Invoke(DTO dto)
    {
        DTO result = new DTO();
        switch (dto.Type)
        {
            case 12:
                result.Data = "Regular User";
                break;
            case 13:
                result.Data = "Super User";
                break;
        }
        return Task.FromResult(result);
    }
}
