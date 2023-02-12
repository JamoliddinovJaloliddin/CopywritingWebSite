using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.OrderDto;
using CopywritingWebSite.Service.Helpers;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CopywritingWebSite.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _appDbContext;

        public OrderService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task CreateAsync(OrderCreateDto dto)
        {
            var order = (Order)dto;
            order.CustomerTheEmpolyeerId = 1;
            order.CustomerWorkerIdId = 0;
            order.CreateAt = TimeHelper.GetCurrentServerTime().ToString();
            order.ArticeStatus = false;
            if (order.AttachedFile != null)
            {
                order.AttachedFile = "";
            }
            else
            {
                order.AttachedFile = "";
            }
            _appDbContext.Orders.Add(order);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var order = await _appDbContext.Orders.FindAsync(id);
            if (order is not null)
            {
                _appDbContext.Orders.Remove(order);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _appDbContext.Orders.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetByIdAsync(long id)
        {
            return await _appDbContext.Orders.Where(x => x.Id == id).AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(long id)
        {
            var order = await _appDbContext.Orders.FindAsync(id);
            order.Id = id;
            order.ArticeStatus = true;
            order.CustomerWorkerIdId = 1;
            _appDbContext.Orders.Update(order);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
