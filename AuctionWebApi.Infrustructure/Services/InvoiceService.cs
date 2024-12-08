using AuctionWebApi.Core.Data;
using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Read;
using AuctionWebApi.Infrastructure.DTOs.Update;
using AuctionWebApi.Infrastructure.Interfaces;
using AutoMapper;

namespace AuctionWebApi.Infrastructure.Services
{
    public class InvoiceService : IEntityService<CreateInvoiceDto, InvoiceDto, UpdateInvoiceDto>
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public InvoiceService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // TODO: Отримати усі чеки
        public List<InvoiceDto> GetAll()
        {
            List<Invoice>invoices = _context.Invoices.ToList();
            return _mapper.Map<List<InvoiceDto>>(invoices);
        }

        // TODO: Отримати чек за Id
        public InvoiceDto GetById(int id)
        {
            Invoice invoice = _context.Invoices.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<InvoiceDto>(invoice);
        }

        // TODO: Створити новий чек
        public void Create(CreateInvoiceDto createDto)
        {
            if (createDto != null)
            {
                Invoice invoice = _mapper.Map<Invoice>(createDto);
                _context.Invoices.Add(invoice);
                _context.SaveChanges();
            }
        }

        // TODO: Видалити чек
        public void Delete(InvoiceDto dto)
        {
            if (dto != null)
            {
                Invoice invoice = _mapper.Map<Invoice>(dto);
                _context.Invoices.Remove(invoice);
                _context.SaveChanges();
            }
        }

        public void Update(UpdateInvoiceDto dto)
        {
            InvoiceDto invoiceOld = GetById(dto.Id);
            if (invoiceOld != null && dto != null)
            {
                Invoice invoice = _mapper.Map<Invoice>(dto);
                _context.Invoices.Update(invoice);
                _context.SaveChanges();
            }
        }
    }
}