using ContactsControl.Models;
using ContactsControl.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ContactsControl.Controllers
{
    public class ContactController : Controller
    {
        private readonly IRepositoryContact _repositoryContact;
        public ContactController(IRepositoryContact repositoryContact)
        {
            _repositoryContact = repositoryContact;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateContact()
        {
            return View();
        }

        public IActionResult EditContact()
        {
            return View();
        }

        public IActionResult RemoveContactConfirmation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ContactModel contact)
        {
            _repositoryContact.Add(contact);
            return RedirectToAction("Index");
        }
    }
}
