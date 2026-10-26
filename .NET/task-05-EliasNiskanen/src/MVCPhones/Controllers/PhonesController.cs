using Microsoft.AspNetCore.Mvc;
using MVCPhones.Data;
using MVCPhones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVCPhones.Controllers
{
    public class PhonesController : Controller
    {
        public IList<Phone> phones { get; set; }

        private readonly PhonesContext phonesContext;

        public PhonesController(PhonesContext phonesContext)
        {
            this.phonesContext = phonesContext;
        }

        public async Task<IActionResult> Index()
        {
            var phones = await phonesContext.Phones.OrderBy(p => p.Make).ThenBy(p=>p.Model).ToListAsync();
            return View(phones);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Add addPhoneRequest) 
        {
            var phone = new Phone()
            {
                Make = addPhoneRequest.Make,
                Model = addPhoneRequest.Model,
                RAM = addPhoneRequest.RAM,
                PublishDate = addPhoneRequest.PublishDate
            };

            await phonesContext.Phones.AddAsync(phone);
            await phonesContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id) 
        {
            var phone = await phonesContext.Phones.FirstOrDefaultAsync(x=>x.Id == Id);
            if(phone != null)
            {
                var editModel = new Edit()
                {
                    Id = phone.Id,
                    Make = phone.Make,
                    Model = phone.Model,
                    RAM = phone.RAM,
                    PublishDate = phone.PublishDate,
                    Created = phone.Created,
                    Modified = phone.Modified
                };
                return await Task.Run(()=> View("Edit", editModel));
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Edit item)
        {
            var phone = await phonesContext.Phones.FindAsync(item.Id);
            if(phone != null)
            {
                phone.Make = item.Make;
                phone.Model = item.Model;
                phone.RAM = item.RAM;
                phone.PublishDate = item.PublishDate;
                phone.Modified = item.Modified;

                await phonesContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {
            var phone = await phonesContext.Phones.FirstOrDefaultAsync(x => x.Id == Id);
            if (phone != null)
            {
                var Deletemodel = new Delete()
                {
                    Id = phone.Id,
                    Make = phone.Make,
                    Model = phone.Model,
                    RAM = phone.RAM,
                    PublishDate = phone.PublishDate,
                    Created = phone.Created,
                    Modified = phone.Modified
                };
                return await Task.Run(() => View("Delete", Deletemodel));
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Delete item)
        {
            var phone = await phonesContext.Phones.FindAsync(item.Id);
            if(phone != null)
            {
                phonesContext.Phones.Remove(phone);
                await phonesContext.SaveChangesAsync();
                return RedirectToAction("Index");
                            
            }
            return RedirectToAction("Index");
        }
    }
}
