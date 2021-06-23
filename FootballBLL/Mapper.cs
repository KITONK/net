using AutoMapper;
using FootballBLL.Models;
using FootballDAL.Entities;
using System;

namespace FootballBLL
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<TeamModel, Team>().ForMember(d => d.Players, opt => opt.MapFrom(src => src.Players)).ReverseMap();
            CreateMap<MatchModel, Match>()
                .ForMember(d => d.Team, opt => opt.MapFrom(src => src.Team))
                .ReverseMap();
            CreateMap<PlayerModel, Player>()
                .ForMember(d => d.IdTeam, opt => opt.MapFrom(src => src.IdTeam))
                .ReverseMap();
        }
    }
}
