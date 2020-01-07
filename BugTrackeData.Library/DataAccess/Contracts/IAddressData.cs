using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;

namespace BugTrackeData.Library.DataAccess.Contracts
{
    public interface IAddressData
    {
        void CreateAddress(AddressModel project);
        void DeleteAddress(Guid id);
        List<AddressData> GetAddress(Guid userId);
        void UpdateAddress(AddressModel project);
    }
}