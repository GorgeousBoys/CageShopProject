using AutoMapper;
using BusinessObject.DTO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Mapper
{
    public class MappingProfiles
    {
        public static void createMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Product, ProductDTO>()
                .ForMember(dto => dto.CategoryName, mdl => mdl.MapFrom(src => src.Category.CategoryName))
                .ForMember(dto => dto.DiscountName, mdl => mdl.MapFrom(src => src.Discount.DiscountName));
        }
    }
}
