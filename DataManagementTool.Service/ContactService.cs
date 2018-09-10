using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataManagementTool.Data;
using DataManagementTool.Repo;

namespace DataManagementTool.Service
{
     public class ContactService : IContactService
    {
        private IRepository<Contact> contactRepository;

        public ContactService(IRepository<Contact> contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public void DeleteContact(long id)
        {
            Contact contact = GetContact(id);
            contactRepository.Remove(contact);
            contactRepository.SaveChanges();
        }

        public void DeleteContactLists(long id)
        {
            IEnumerable<Contact> contacts = GetContacts().Where(d => d.Id == id);
            contactRepository.RemoveRange(contacts);
            contactRepository.SaveChanges();
        }

        public Contact GetContact(long id)
        {
            return contactRepository.Get(id);
        }
        public IEnumerable<Contact> GetContactsWithLazyLoad()
        {
            string[] include = new string[] { "ContactList" };
            return contactRepository.GetAll(include);
        }
        public IQueryable<Contact> GetContacts()
        {
            return contactRepository.GetAll();
        }
        public void InsertContact(Contact contact)
        {
            contactRepository.Insert(contact);
        }

        public void UpdateContact(Contact contact)
        {
            contactRepository.Update(contact);
        }
        public IQueryable<Data.Contact> RunStoredProcedure(string commandName, string[] parameteres)
        {
            return contactRepository.RunStoredProcedure(commandName, parameteres);
        }
    }
}
