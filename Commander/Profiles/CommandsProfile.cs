﻿using AutoMapper;
using Commander.Dtos;
using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Profiles
{
    public class CommandsProfile:Profile
    {
        public CommandsProfile()
        {
            //source=>Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandWriteDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}
