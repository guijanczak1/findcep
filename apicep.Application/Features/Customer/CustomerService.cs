using apicep.Application.Features.Dtos;
using apicep.Infrastructure;
using apicep.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace apicep.Application.Features
{
    public class CustomerService
    {
        ApiCepDbContext db;

        public CustomerService(ApiCepDbContext db)
        {
            this.db = db;
        }

        public async Task CreateAsync(CreateCustomerRequest request)
        {
            var customer = new Customer
            {
                CustomerId = Guid.NewGuid(),
                Name = request.Name,
                BirthDate = request.BirthDate,
                CustomerPhones = request.Phones
                    .Select(x => new CustomerPhone
                    {
                        CustomerPhoneId = Guid.NewGuid(),
                        PhoneNumber = x.PhoneNumber,
                    })
                    .ToList()
            };

            await db.Customers.AddAsync(customer);

            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync(GetAllCustomerRequest request)
        {
            var query = db.Customers.AsQueryable();

            var totalRows = await query.CountAsync();

            var birthDate = await query.MaxAsync(x => x.BirthDate);

            if(!string.IsNullOrWhiteSpace(request.Name))
            {
                query = query.Where(x => x.Name.Contains(request.Name));
            }

            var customers = await query
                .OrderBy(x => x.Name)
                .Include(x => x.CustomerPhones)
                .ToListAsync();

            return customers;
        }
    }
}
