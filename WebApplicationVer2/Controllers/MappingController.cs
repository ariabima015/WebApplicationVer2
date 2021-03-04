using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVer2.Models;

namespace WebApplicationVer2.Controllers
{
    public class MappingController : Controller
    {
        private readonly DatabaseContext _context;
        public MappingController(DatabaseContext context)
        {
            _context = context;
        }
        // GET: Mapping/Create
        public async Task<IActionResult> CreateAsync()
        {
            ViewData["CityName"] = new SelectList(_context.Cities, "GroupId", "Name");
            ViewData["WarehouseName"] = new SelectList(_context.Warehouses, "WarehouseId", "Name");

            MappingViewModel mappingViewModel = new MappingViewModel();

            var cities = _context.Cities;
            var warehouses = _context.Warehouses;
            mappingViewModel.MappingList = await cities
                .Join(warehouses,
                city => city.Group,
                warehouse => warehouse.Group,
                (city, warehouse) =>
                new MappingIndexViewModel
                {
                    City = city,
                    Group = city.Group,
                    Warehouse = warehouse
                })
                .ToListAsync();

            return View(mappingViewModel);
        }

        // POST: Mapping/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MappingViewModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in model.WarehouseIdList)
                {
                    Warehouse warehouse = await _context.Warehouses.FindAsync(item);
                    warehouse.GroupId = model.GroupId;
                    _context.Update(warehouse);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Create");
        }
    }
}
