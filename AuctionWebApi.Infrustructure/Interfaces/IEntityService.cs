using AuctionWebApi.Infrastructure.DTOs;

namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IEntityService<CreateDto, Dto, UpdateDto>
    {
        List<Dto> GetAll();
        Dto GetById(int id);
        void Create(CreateDto createDto);
        void Update(UpdateDto dto);
        void Delete(Dto dto);
    }
}