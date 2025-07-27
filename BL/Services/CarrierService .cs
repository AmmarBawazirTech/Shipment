using AutoMapper;
using BL.Dto;
using BL.Interfaces;
using DataAcessesLayer.Contract;
using DataAcessesLayer.Data;
using DataAcessesLayer.Repositories;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Services
{
    public class CarrierService : BaseService<CarrierDto, TbCarrier>, ICarrierService
    {
        public CarrierService(IGenericRepository<TbCarrier> repo, IMapper mapper)
            : base(repo, mapper)
        {
        }
    }
}
