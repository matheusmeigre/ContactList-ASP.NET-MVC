using ContactsControl.Models;

namespace ContactsControl.Repositorio
{
    public interface IRepositoryContact
    {
        ContactModel Add(ContactModel contact);
    }
}
