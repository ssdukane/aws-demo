using Microsoft.Extensions.Options;
using OMB.Application.Configuration;
using OMB.Application.Interfaces;
using OMB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMB.DataAccessLayer;

public class OwnerRepository : IOwnerRepository
{
    private readonly OMBContext _context;
    private readonly IOptions<ApplicationOptions> _options;

    public OwnerRepository(OMBContext context, IOptions<ApplicationOptions> options)
    {
        _context = context;
        _options = options;
    }
    public IEnumerable<Owner> GetOwners()
    {
        var owners = _context.Owners.ToList();

        return (IEnumerable<Owner>)owners;
    }

    public async Task AddOwner()
    {
        var owner = new Owner();
        owner.Id = Guid.NewGuid();
        owner.FirstName = "Mohan";
        owner.LastName = "Dukane";
        owner.BusinessName = "MSD";
        owner.DisplayName = "OMB";
        owner.Mobile = "9860555968";
        try
        {
            await _context.Owners.AddAsync(owner);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw;
        }
       
    }

    public async Task AddCustomer()
    {
        var owner = new Owner();
        //owner.Id = Guid.NewGuid();
        owner.FirstName = "Mohan";
        owner.LastName = "Dukane";
        owner.BusinessName = "MSD";
        owner.DisplayName = "OMB";
        owner.Mobile = "9860555968";

        await _context.Owners.AddAsync(owner);
        _context.SaveChanges();
    }
}
