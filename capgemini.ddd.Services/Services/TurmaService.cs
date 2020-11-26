using capgemini.ddd.Domain.Interfaces.Repositories;
using capgemini.ddd.Domain.Interfaces.Services;
using capgemini.ddd.Domain.Models;
using capgemini.ddd.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace capgemini.ddd.Service.Services
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository _repository;
        private readonly IBaseRepository _baseRepository;

        public TurmaService(ITurmaRepository repository, IBaseRepository baseRepository)
        {
            _repository = repository;
            _baseRepository = baseRepository;
        }

        public IEnumerable<Turma> GetAll()
        {
            var result = _repository.GetAll();

            return result ?? throw new Exception("Não foram encontrados turmas cadastradas.");
        }

        public bool Add(Turma value)
        {
            return _baseRepository.Add(value);
        }
    }
}