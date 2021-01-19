using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
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
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository,IMapper mapper)
        {
            _repo = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandItems = _repo.GetAllComands();
            if (commandItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
            }
            return NotFound();
        }

        [HttpGet("{id}",Name = "GetCommandById")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
           var command= _repo.GetCommandById(id);
            if (command != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(command));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandWriteDto commandWriteDto)
        {
            if (commandWriteDto != null)
            {
                var command = _mapper.Map<Command>(commandWriteDto);
                _repo.CreateCommand(command);
                _repo.SaveChange();
                var commandReadDto = _mapper.Map<CommandReadDto>(command);
                return CreatedAtRoute(nameof(GetCommandById), new { Id = commandReadDto.Id }, commandReadDto);
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id,CommandUpdateDto commandUpdateDto)
        {
            var commandFromRepo = _repo.GetCommandById(id);
            if (commandFromRepo != null)
            {
                _mapper.Map(commandUpdateDto, commandFromRepo);
                _repo.UpdateCommand(commandFromRepo);
                _repo.SaveChange();
                return NoContent();
            }
            return NotFound();
        }

    }
}
