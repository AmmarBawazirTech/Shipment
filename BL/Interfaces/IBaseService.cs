using DomainLayer.Models;
using System;
using System.Collections.Generic;

namespace BL.Interfaces
{
    public interface IBaseService<TDto>
    {
        List<TDto> GetAll();
        TDto GetById(Guid id);
        bool Add(TDto dto, Guid userId);
        bool Update(TDto dto, Guid userId);
        bool ChangeStatus(Guid id, Guid userId, int status = 1);
    }
}
