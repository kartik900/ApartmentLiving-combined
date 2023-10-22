using FriendsAndFamilyAPI.Models;
using FriendsAndFamilyAPI.Models.ViewModels;
using FriendsAndFamilyAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsAndFamilyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaFController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(FaFController));
        private readonly IFaFRepos _context;
        public FaFController(IFaFRepos context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<FafDetails> GetAllFriendsAndFamily()
        {
            _log4net.Info("Get All FriendsAndFamily Was Called !!");
            return _context.GetAllFriendsAndFamily();
        }
        [HttpGet("{id}")]
        public IActionResult GetFriendsAndFamilyByResidentId(int id)
        {
            _log4net.Info("GetFriendsAndFamilyByResidentId By ID Was Called !!");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var faflist = _context.GetFriendsAndFamilybyResidentId(id);
                _log4net.Info("GetFriendsAndFamilyByResidentId With Resident Id " + id + " Was Called !!");
                if (faflist == null)
                {
                    return NotFound();
                }
                return Ok(faflist);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostFriendsAndFamily(FriendsAndFamily item)
        {
            _log4net.Info("Post FriendsAndFamily Was Called !!");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var addfaf = await _context.PostFriendsAndFamily(item);
                return Ok(addfaf);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
