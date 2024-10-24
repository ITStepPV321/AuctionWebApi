namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IEntityService<CreateDto, Dto>
    {
        List<Dto> GetAll();
        Dto GetById(int id);
        void Create(CreateDto createDto);
        void Update(Dto dto);
        void Delete(Dto dto);
    }
}