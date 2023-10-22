using FriendsAndFamilyAPI.Models;
using FriendsAndFamilyAPI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsAndFamilyAPI.Repositories
{
    public interface IFaFRepos
    {
        IEnumerable<FafDetails> GetAllFriendsAndFamily();
        public IEnumerable<FriendsAndFamily> GetFriendsAndFamilybyResidentId(int id);
        public Task<FriendsAndFamily> PostFriendsAndFamily(FriendsAndFamily item);


    }
}
