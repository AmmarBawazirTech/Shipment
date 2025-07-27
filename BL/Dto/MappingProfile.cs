using AutoMapper;
using DomainLayer.Models;
using Shipment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dto
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TbUserSubscription, UserSubscriptionDto>().ReverseMap();
            CreateMap<TbUserSebder, UserSenderDto>().ReverseMap();
            CreateMap<TbUserReceiver, UserReceiverDto>().ReverseMap();
            CreateMap<TbSubscriptionPackage, SubscriptionPackageDto>().ReverseMap();
            CreateMap<TbShippmentStatus, ShippmentStatusDto>().ReverseMap();
            CreateMap<TbShippment, ShipmentDto>().ReverseMap();
            CreateMap<TbShippingType, ShippingTypeDto>().ReverseMap();
            CreateMap<TbSetting, SettingDto>().ReverseMap();
            CreateMap<TbPaymentMethod, PaymentMethodDto>().ReverseMap();
            CreateMap<TbCountry, CountryDto>().ReverseMap();
            CreateMap<TbCity, CityDto>().ReverseMap();
            CreateMap<TbCarrier, CarrierDto>().ReverseMap();
        }
    }

}
