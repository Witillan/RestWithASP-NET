using System;
using RestWithASPNET.Model;
using System.Collections.Generic;
using System.Threading;

namespace RestWithASPNET.Business.Implementtations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private PersonRepositoryImpl _repository;
        
        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = (PersonRepositoryImpl)repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Uptade(Person person)
        {
            return _repository.Uptade(person);
        }
    }
}
