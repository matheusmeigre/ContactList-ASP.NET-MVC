using ContactsControl.Data;
using ContactsControl.Models;

namespace ContactsControl.Repositorio
{
    public class RepositoryContact : IRepositoryContact
    {
        private readonly BancoContext _bancoContext;
        public RepositoryContact(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }

        public List<ContactModel> ChangeAll()
        {
            return _bancoContext.Contacts.ToList();
        }

        public ContactModel Add(ContactModel contact)
        {
            _bancoContext.Contacts.Add(contact);
            _bancoContext.SaveChanges();
            return contact;
        }
    }
}
