using AutoMapper;

using AysanRaf.NakliyeMontaj.Entites.DTOs;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysanRaf.NakliyeMontaj.Business.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile() {
            CreateMap<ShippingInstallationCustomer, ShippingInstallationCustomerForDetailDto>().ReverseMap();
            CreateMap<ShippingInstallationCustomer, ShippingInstallationCustomerForPostDto>().ReverseMap();
            CreateMap<ShippingInstallationCustomer, ShippingInstallationCustomerForUpdateDto>().ReverseMap();


            CreateMap<RentedEquipment, RentedEquipmentForPostDto>().ReverseMap();
            CreateMap<RentedEquipment, RentedEquipmentForUpdateDto>().ReverseMap();
            CreateMap<RentedEquipment, RentedEquipmentForDetailDto>().ReverseMap();


            CreateMap<PlannedOfferForm, PlannedOfferFormForPostDto>().ReverseMap();
            CreateMap<PlannedOfferForm, PlannedOfferFormForUpdateDto>().ReverseMap();
            CreateMap<PlannedOfferForm, PlannedOfferFormForDetailDto>().ReverseMap();
            CreateMap<PlannedOfferForm, PlannedOfferFormForListDto>().ReverseMap();

            CreateMap<RealizedOfferForm, RealizedOfferFormForPostDto>().ReverseMap();
            CreateMap<RealizedOfferForm, RealizedOfferFormForUpdateDto>().ReverseMap();
            CreateMap<RealizedOfferForm, RealizedOfferFormForDetailDto>().ReverseMap();
            CreateMap<RealizedOfferForm, RealizedOfferFormForListDto>().ReverseMap();
        }
    }
}
