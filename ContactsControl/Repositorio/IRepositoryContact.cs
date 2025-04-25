using ContactsControl.Models;

namespace ContactsControl.Repositorio
{
    public interface IRepositoryContact
    {
        List<ContactModel> ChangeAll();
        ContactModel Add(ContactModel contact);
    }
}
