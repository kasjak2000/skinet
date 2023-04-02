using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        // empty contructor
        public MappingProfiles()
        {
            // From Product from Core.Entities and we want to go to ProductToReturnDto from API.Dtos
            // as long variables in this classes have same names, we dont need add extra configuration
            CreateMap<Product, ProductToReturnDto>()
                // Destination is ProductToReturnDto.ProductBrand and Source Product.ProductBrand.Name
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                // Destination is ProductToReturnDto.PictureUrl and Source ProductUrlResolver>()
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());



        }






    }
}