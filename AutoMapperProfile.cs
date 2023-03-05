using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<GetCharacterDto, Character>();
            CreateMap<Character, AddCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Character, UpdateCharacterDto>();
            CreateMap<UpdateCharacterDto, Character>();
        }
    }
}