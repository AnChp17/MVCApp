using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCApp.Models;
using MVCApp.Dtos;
using AutoMapper;

namespace MVCApp.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/customers
        public IHttpActionResult GetCustomers()
        {
            var customerDtos = _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);

            return Ok(customerDtos);
        }

        // GET api/customer/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.ID == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        // POST api/customers

        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.ID = customer.ID;

            return Created(new Uri(Request.RequestUri + "/" + customer.ID), customerDto);
        }

        // PUT api/customer
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == id);

            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto,customerInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE api/customer

        public IHttpActionResult DeleteCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == customer.ID);

            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return Ok();

        }


    }
}
