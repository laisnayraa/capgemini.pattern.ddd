using capgemini.ddd.Domain.Interfaces.Repositories;
using capgemini.ddd.Domain.Interfaces.Services;
using capgemini.ddd.Domain.Models;
using capgemini.ddd.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace capgemini.ddd.Service.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _repository;
        private readonly IBaseRepository _baseRepository;

        public AlunoService(IAlunoRepository repository, IBaseRepository baseRepository)
        {
            _repository = repository;
            _baseRepository = baseRepository;
        }

        public IEnumerable<Aluno> GetAll()
        {
            var result = _repository.GetAll();

            return result ?? throw new Exception("Não foram encontrados alunos cadastrados.");
        }

        public bool Add(Aluno value)
        {
            return _baseRepository.Add(value);
        }
    }
}
