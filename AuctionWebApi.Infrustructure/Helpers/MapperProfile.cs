using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Read;
using AuctionWebApi.Infrastructure.DTOs.Read.BetHistory;
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
                    dto => dto.BetHistoryIds,
                    opt => opt.MapFrom(entity => entity.BetHistories.Select(betHistory => betHistory.Id)));

            CreateMap<CreateUserDto, User>()
                .ForMember(entity => entity.UserName, opt => opt.MapFrom(dto => dto.UserName))
                .ForMember(entity => entity.Email, opt => opt.MapFrom(dto => dto.Email))
                .ForMember(entity => entity.Auctions, opt => opt.Ignore())
                .ForMember(entity => entity.BetHistories, opt => opt.Ignore());

            CreateMap<AuctionDto, Auction>().ReverseMap();
            CreateMap<CreateAuctionDto, Auction>();
            CreateMap<UpdateAuctionDto, Auction>();

            CreateMap<InvoiceDto, Invoice>().ReverseMap();
            CreateMap<CreateInvoiceDto, Invoice>();
            CreateMap<UpdateInvoiceDto, Invoice>();

            CreateMap<BetHistoryDto, BetHistory>().ReverseMap();
            CreateMap<CreateBetHistoryDto, BetHistory>();
            CreateMap<BetHistory, MaxBet>()
                .ForMember(dto => dto.UserName, opt => opt.MapFrom(entity => entity.User.UserName));
        }

    }
}