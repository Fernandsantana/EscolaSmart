using EscolaSmart.Helpers;
using EscolaSmart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaSmart.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();


        //Alunos
        Task<PageList<Aluno>> GetAllAlunosAsync(PageParams pageParams, bool includeProfessor = false);
        Aluno[] GetAllAlunos(bool includeProfessor = false);

        Task<Aluno[]> GetAllAlunosByDisciplinaIdAsync(int disciplinaId, bool includeProfessor = false);
        Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);

        Task<Aluno> GetAllAlunoByIdAsync(int alunoId, bool includeProfessor = false);
        Aluno GetAllAlunoById(int alunoId, bool includeProfessor = false);


        //Professores
        Task<Professor[]> GetAllProfessoresAsync(bool includeAlunos = false);
        Professor[] GetAllProfessores(bool includeAlunos = false);

        Task<Professor[]> GetAllProfessoresByDisciplinaIdAsync(int disciplinaId, bool includeAlunos = false);
        Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false);

        Task<Professor> GetAllProfessorByIdAsync(int professorId, bool includeProfessor = false);
        Professor GetAllProfessorById(int professorId, bool includeAlunos = false);

        Professor[] GetAllProfessoresByAlunoId(int alunoId, bool includeAlunos = false);
    }
}
