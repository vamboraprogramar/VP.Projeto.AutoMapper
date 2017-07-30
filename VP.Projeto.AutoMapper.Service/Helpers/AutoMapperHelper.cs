using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP.Projeto.AutoMapper.Service.Helpers
{
    public static class AutoMapperHelper
    {
        public static void InitializeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Atlassian.Jira.Issue, Model.Issue>()
                    .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Key.Value))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.Name))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.Name));

                cfg.CreateMap<Model.Issue, Atlassian.Jira.Issue>();
            });
        }
    }
}
