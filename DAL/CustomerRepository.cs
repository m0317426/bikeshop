using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class CustomerRepository:ICustomerRepository
    {
        DataContext context;

        public CustomerRepository(DataContext _context)
        {
            context = _context;
        }

        public List<Customer> Get()
        {
            return context.Customers.ToList();
        }

        public Customer FindById(int id)
        {
            return context.Customers.Where(u => u.CustomerId == id).Single();
        }

        public void Update(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }

        public void Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var customer = context.Customers.SingleOrDefault(u => u.CustomerId == id);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
    }
}
