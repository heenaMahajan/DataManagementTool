using DataManagementTool.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataManagementTool.Service
{
    public interface IContactService
    {
        IQueryable<Contact> GetContacts();
        Contact GetContact(long id);
        IEnumerable<Contact> GetContactsWithLazyLoad();
        void InsertContact(Contact contact);
        void DeleteContact(long id);
        void DeleteContactLists(long id);
        void UpdateContact(Contact contact);
        IQueryable<Data.Contact> RunStoredProcedure(string commandName, string[] parameteres);
    }
}
