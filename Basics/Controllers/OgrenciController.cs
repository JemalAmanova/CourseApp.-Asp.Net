using Microsoft.AspNetCore.Mvc;
using Basics.Data;
using Microsoft.EntityFrameworkCore;

namespace Basics.Controllers{
    public class OgrenciController: Controller{

      private readonly DataContext _context;
      public OgrenciController(DataContext context)
      {
        _context=context;
      }

      //Öğrenci listeleme:
      public async Task<IActionResult> Index(){
        //yine async- yöntem kullanarak listeleme yapıyoruz;
       
        return View(await _context.Ogrenciler.ToListAsync());
      }
  public IActionResult Create(){
    return View();
  }
//Öğrenci kayıt:
  [HttpPost]
  //Async- yöntem kullanıyoruz;
  public async Task<IActionResult>Create(Ogrenci model){
    _context.Ogrenciler.Add(model);
    await _context.SaveChangesAsync();
    return RedirectToAction("Index", "Home");
    
  }
    }
}