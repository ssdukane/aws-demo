﻿using OMB.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OMB.Application.Interfaces
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetOwners();
        public Task AddOwner();
        public Task AddCustomer();
    }
}
