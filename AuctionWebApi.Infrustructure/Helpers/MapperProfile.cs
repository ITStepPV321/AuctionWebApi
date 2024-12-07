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
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>()
                .ForMember(
                    dto => dto.AuctionIds,
                    opt => opt.MapFrom(entity => entity.Auctions.Select(auction => auction.Id).ToList()))
                .ForMember(
                    dto => dto.InvoiceIds,
                    opt => opt.MapFrom(entity => entity.Invoices.Select(invoice => invoice.Id)));

            CreateMap<CreateUserDto, User>()
                .ForMember(entity => entity.UserName, opt => opt.MapFrom(dto => dto.UserName))
                .ForMember(entity => entity.Email, opt => opt.MapFrom(dto => dto.Email))
                .ForMember(entity => entity.Auctions, opt => opt.Ignore())
                .ForMember(entity => entity.Invoices, opt => opt.Ignore());

            CreateMap<AuctionDto, Auction>().ReverseMap();
            CreateMap<CreateAuctionDto, Auction>();
            CreateMap<UpdateAuctionDto, Auction>();

            CreateMap<InvoiceDto, Invoice>().ReverseMap();
            CreateMap<CreateInvoiceDto, Invoice>();
            CreateMap<UpdateInvoiceDto, Invoice>();


        }

    }
}