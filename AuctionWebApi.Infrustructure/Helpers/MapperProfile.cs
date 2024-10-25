using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AutoMapper;

namespace AuctionWebApi.Infrastructure.Helpers
{
    public class MapperProfile:Profile
    {
        // TODO: Додати мапінґи для користувача
        // LOGIC
        public MapperProfile()
        {
            
            CreateMap<ProductDto,Product>().ReverseMap();
            CreateMap<CreateProductDto, Product>();


            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<CreateUserDto, User>();


            CreateMap<AuctionDto, Auction>().ReverseMap();
            CreateMap<CreateAuctionDto, Auction>();


            CreateMap<InvoiceDto, Invoice>().ReverseMap();
            CreateMap<CreateInvoiceDto, Invoice>();


        }

        // TODO: Додати мапінґи для продукту
        // LOGIC

        // TODO: Додати мапінґи для аукціону
        // LOGIC

        // TODO: Додати мапінґи для чеку
        // LOGIC

    }
}