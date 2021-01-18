using Commander.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController:ControllerBase
    {
        private readonly ICommanderRepo _repo;

        public CommandsController(ICommanderRepo repository)
        {
            _repo = repository;
        }
        //private readonly MockCommanderRepo _repo = new MockCommanderRepo();
        [HttpGet]
        public IActionResult GetAllCommands()
        {
            var commandItems = _repo.GetAllComands();
            return Ok(commandItems);
        }
        [HttpGet("{id}")]
        public IActionResult GetCommandById(int id)
        {
           var command= _repo.GetCommandById(id);
            return Ok(command);
        }

    }
}
