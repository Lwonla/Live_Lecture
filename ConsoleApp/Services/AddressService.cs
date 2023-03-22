using ConsoleApp.Contexts;
using ConsoleApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ConsoleApp.Services
{
    internal class AddressService
    {
        private readonly DataContext _context = new DataContext();

        public async Task<IEnumerable<AddressEntity>> GetAllAsync()
        {
            return await _context.Addresses.ToListAsync(); //_______________
        }

        //public async Task<AddressEntity> GetAsync(int id)
        //{
        //var item = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == id);
        //    if (item != null)
        //    {
        //        return item;
        //    }
        //    return null!;
        //}


        public async Task<AddressEntity> GetAsync(int id)
        {
            //Funk
            var item = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == id);
            if (item != null)
                return item;

            return null;
        }

    }
}
