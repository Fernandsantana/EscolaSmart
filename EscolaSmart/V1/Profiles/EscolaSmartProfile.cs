using AutoMapper;
using EscolaSmart.V1;
using EscolaSmart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscolaSmart.V1.Dtos;
using EscolaSmart.Helpers;

namespace EscolaSmart.V1.Profiles
{
    public class EscolaSmartProfile : Profile
    {
        public EscolaSmartProfile()
        {
            CreateMap<Aluno, AlunoDto>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => $"{src.Nome} {src.Sobrenome}"))
                .ForMember(dest => dest.Idade, opt => opt.MapFrom(src => src.DataNasc.GetCurrentAge()));

            CreateMap<AlunoDto, Aluno>();
            CreateMap<Aluno, AlunoRegistrarDto>().ReverseMap();
            CreateMap<Aluno, AlunoPatchDto>().ReverseMap();

            CreateMap<Professor, ProfessorDto>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => $"{src.Nome} {src.Sobrenome}"));

            CreateMap<ProfessorDto, Professor>();
            CreateMap<Professor, ProfessorRegistrarDto>().ReverseMap();

            CreateMap<DisciplinaDto, Disciplina>().ReverseMap();
            CreateMap<CursoDto, Curso>().ReverseMap();
        }
    }
}
