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

        Aluno[] GetAllAlunos(bool includeProfessor = false);

        Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);

        Aluno GetAllAlunoById(int alunoId, bool includeProfessor = false);

        Professor[] GetAllProfessores(bool includeAlunos = false);

        Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false);

        Professor GetAllProfessorById(int professorId, bool includeProfessor = false);



    }
}
