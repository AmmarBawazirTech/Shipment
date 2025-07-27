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
    public class ShipmentService : BaseService<ShipmentDto,TbShippment>, IShipmentService
    {

        public ShipmentService(IGenericRepository<TbShippment> repo,IMapper mapper):base(repo,mapper)
        {
        }

       
    }
}
