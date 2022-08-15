using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mySmartWallet2022.Models.Data.Entities;
using mySmartWallet2022.Models.Data.Interface;
using mySmartWallet2022.Models.Data.Reposiory;

namespace mySmartWallet2022.Controllers
{
    public class CustomersController : Controller
    { 
        private readonly IRepository<Customer, Guid> _CustomerRepo;

        public CustomersController(IRepository<Customer, Guid> customerRepo)
        {
            _CustomerRepo = customerRepo;
        }

        public async Task<IActionResult> Index()
        {
            var customer = await _CustomerRepo.GetAll();
            return View(customer);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new Customer { DateOfBirth = DateTime.Now, Active = true };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                model.RegisterationDate = DateTime.Now; 
                await _CustomerRepo.Create(model);
                return RedirectToAction("Index", "Customers");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await _CustomerRepo.Edit(id);

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Customer model)
        {
           await  _CustomerRepo.Update(model);

            return RedirectToAction("Index", "Customers");
        }
        public async Task<IActionResult> GetId(Guid id)
        {
            var model = await _CustomerRepo.GetSingle(id);
            return View(model);
        }
        public async Task<IActionResult> Delete(Guid id)
        {
           await _CustomerRepo.Delete(id);

        return RedirectToAction("Index", "Customers");
        }

    }
}
