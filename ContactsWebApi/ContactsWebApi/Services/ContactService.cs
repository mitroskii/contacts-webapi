using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;
using ContactsWebApi.Repositories;

namespace ContactsWebApi.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService()
        {

        }

        public List<Contact> GetContacts()
        {
            throw new NotImplementedException();
        }
    
    public Contact GetContactById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
