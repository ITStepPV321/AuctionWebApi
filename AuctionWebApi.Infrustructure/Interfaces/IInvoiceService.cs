using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Read;
using AuctionWebApi.Infrastructure.DTOs.Update;

namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IInvoiceService
    {
        List<InvoiceDto> GetAll();
        InvoiceDto GetById(int id);
        InvoiceDto GetByBetHistoryId(int betHistoryId);
        void Create(CreateInvoiceDto createDto);
        void Update(UpdateInvoiceDto dto);
        void Delete(InvoiceDto dto);
    }
}
