using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source to target
            CreateMap<Command, CommandReadDto>();

            //back
            CreateMap<CommandCreateDto, Command>();
        }
    }


}