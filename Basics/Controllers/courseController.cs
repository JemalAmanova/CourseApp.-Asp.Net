//modelleri ekledik
using Basics.Models;
//Controllerin ait olduğu namespace'i ekledik.
using Microsoft.AspNetCore.Mvc;
//Namespace: projemizin ismini ve klasörün adını barındırır
namespace Basics.Controllers;
//courseController adında bir klas ekledik, ve bu klasın bir controller olduğunu tanımladık.
public class courseController: Controller{
  
 
  
   //bir action metod tanımladık
   public IActionResult Details (int id){
      //kurs adında bir değiken tanımladık ve Id ye eşitledik
    var kurs=Repository.GetById(id);
      
     return View(kurs);
  }
 //Bir tane daha metod tanımladık
  public IActionResult list (){
    
     return View("CourseList", Repository.Courses);
  }
 


}