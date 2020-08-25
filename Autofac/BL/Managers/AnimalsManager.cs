using AutoMapper;
using BL.Interfaces;
using BL.Model;
using DAL.Interfaces;
using DAL.Model;
using System.Collections.Generic;

namespace BL.Managers
{
    public class AnimalsManager : IAnimalsManager
    {
        public IAnimalsRepository _repository;

        public readonly Mapper _mapper;

        public AnimalsManager(IAnimalsRepository repository)
        {
            _repository = repository;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Animal, AnimalModel>();
                cfg.CreateMap<House, HouseModel>();
            });
            _mapper = new Mapper(config);
        }
        public IList<AnimalModel> GetAllAnimals()
        {
            var result = _mapper.Map<IList<AnimalModel>>(_repository.GetAllAnimals());
            return result;
        }
    }
}
