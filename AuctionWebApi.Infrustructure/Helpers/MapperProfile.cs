using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Update;
using AutoMapper;

namespace AuctionWebApi.Infrastructure.Helpers
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<ProductDto,Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>();
            CreateMap<CreateProductDto, Product>();

            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<CreateUserDto, User>()
                .ForMember(entity => entity.UserName, opt => opt.MapFrom(dto => dto.UserName))
                .ForMember(entity => entity.Email, opt => opt.MapFrom(dto => dto.Email))
                .ForMember(entity => entity.Auctions, opt => opt.Ignore())
                .ForMember(entity => entity.Invoices, opt => opt.Ignore());
            CreateMap<UpdateUserDto, User>()
                .ForMember(entity => entity.UserName, opt => opt.MapFrom(dto => dto.UserName))
                .ForMember(entity => entity.Email, opt => opt.MapFrom(dto => dto.Email))
                .ForMember(entity => entity.Auctions, opt => opt.Ignore())
                .ForMember(entity => entity.Invoices, opt => opt.Ignore());

            // TODO: Додати мапінґи для аукціону
            CreateMap<AuctionDto, Auction>().ReverseMap();
            CreateMap<CreateAuctionDto, Auction>();

            // TODO: Додати мапінґи для чеку
            CreateMap<InvoiceDto, Invoice>().ReverseMap();
            CreateMap<CreateInvoiceDto, Invoice>();


        }

    }
}