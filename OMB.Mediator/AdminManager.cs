using Factory.Business;
using Factory.Interface;
using Microsoft.AspNetCore.Mvc;
using OMB.Application.Interfaces;

namespace OMB.Mediator;

public class AdminManager : IInvoke
{
    private IOwnerRepository _ownerRepository;
    public AdminManager(IOwnerRepository ownerRepository)
    {
        _ownerRepository = ownerRepository;
    }
    [HttpPost]
    [Route("Invoke")]
    public async Task<DTO> Invoke(DTO dto)
    {
        DTO result = new DTO();
        switch (dto.Type)
        {
            case 101:
                await _ownerRepository.AddOwner();
                break;
            case 102:
                await _ownerRepository.AddCustomer();
                break;
        }
        return result;
    }
}
