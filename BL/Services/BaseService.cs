using AutoMapper;
using BL.Interfaces;
using DataAcessesLayer.Contract;
using DataAcessesLayer.Data;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Services
{
    public class BaseService<TDto, TEntity> : IBaseService<TDto>
     where TEntity : BaseTable
    {
        private readonly IGenericRepository<TEntity> _genericRepository;
        private readonly IMapper _mapper;

        public BaseService(IGenericRepository<TEntity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public List<TDto> GetAll()
        {
            var entities = _genericRepository.GetAll();
            return _mapper.Map<List<TDto>>(entities);
        }

        public TDto GetById(Guid id)
        {
            var entity = _genericRepository.GetById(id);
            return _mapper.Map<TDto>(entity);
        }

        public bool Add(TDto dto, Guid userId)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity.CreatedBy = userId;
            return _genericRepository.Add(entity);
        }

        public bool Update(TDto dto, Guid userId)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity.UpdatedBy = userId;
            return _genericRepository.Update(entity);
        }

        public bool ChangeStatus(Guid id, Guid userId, int status = 1)
        {
            return _genericRepository.ChangeStatus(id, status);
        }
    }

}
