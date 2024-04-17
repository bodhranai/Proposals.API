using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proposals.API.Data;
using Proposals.API.Entities;

namespace Proposals.API.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProposalController : ControllerBase
    {
        private readonly ILogger<ProposalController> _logger;

        private readonly IConfiguration _configuration;
        private readonly DataContext _context;

        public ProposalController(ILogger<ProposalController> logger, IConfiguration configuration, DataContext context)
        {
            _logger = logger;
            _configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Experiment>> GetProposals()
        {
            var data = await _context.Experiment.ToListAsync();
            return data;
           
        } 
        [HttpPost]
        public async Task<IEnumerable<Experiment>> AddProposal(Experiment experiment)
        {
            _context.Experiment.Add(experiment);
            _context.SaveChanges();
            return await _context.Experiment.ToListAsync();
            
           
        }
        [HttpPost]
        public async Task<IEnumerable<User>> AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return await _context.Users.ToListAsync();
            
           
        }
        [HttpGet("{id}")]
        public async Task<IEnumerable<User>> GetUsers(int id)
        {
            var data =  _context.Users.Where(a=>a.ExperimentId==id).ToList();
            return data;

            
        }
    }
}

