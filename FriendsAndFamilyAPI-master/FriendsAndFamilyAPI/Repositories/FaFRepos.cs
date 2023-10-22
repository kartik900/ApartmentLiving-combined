using FriendsAndFamilyAPI.Models;
using FriendsAndFamilyAPI.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsAndFamilyAPI.Repositories
{
    public class FaFRepos: IFaFRepos
    {
        private readonly CommunityGateDatabaseContext _context;

        public FaFRepos()
        {

        }

        public FaFRepos(CommunityGateDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<FafDetails> GetAllFriendsAndFamily()
        {

            List<FriendsAndFamily> data = _context.FriendsAndFamily.Include(x => x.Resident).ToList();

            List<FafDetails> fafDetailsList = new List<FafDetails>();
            foreach (var ser in data)
            {
                FafDetails tempfafdetails = new FafDetails()
                {
                    FaFid = ser.FaFid,
                    ResidentHouseNo = ser.Resident.ResidentHouseNo,
                    ResidentName = ser.Resident.ResidentName,
                    FaFname = ser.FaFname,
                    ResidentId = ser.ResidentId,
                    Relation = ser.Relation,
                    ResidentMobileNo = ser.Resident.ResidentMobileNo
                };
                    fafDetailsList.Add(tempfafdetails);
            }
            return fafDetailsList;
        }

        public IEnumerable<FriendsAndFamily> GetFriendsAndFamilybyResidentId(int id)
        {
            return _context.FriendsAndFamily.Where(f=>f.ResidentId==id).ToList();
        }

        public async Task<FriendsAndFamily> PostFriendsAndFamily(FriendsAndFamily item)
        {
            FriendsAndFamily faf = null;
            if (item == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                faf = new FriendsAndFamily() {
                    FaFname = item.FaFname,
                    Relation = item.Relation,
                    ResidentId = item.ResidentId
                };
                await _context.FriendsAndFamily.AddAsync(faf);
                await _context.SaveChangesAsync();
            }
            return faf;
        }
    }
}
