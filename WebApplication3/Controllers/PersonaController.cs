using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PersonaController : Controller
    {
        // GET: PersonaController

        Context ContextoPersona = new Context();
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Persona model)
        {
            ContextoPersona.Persona.Add(model);
            ContextoPersona.SaveChanges();
            return View();
        }

        // GET: PersonaController/Edit/5
        public ActionResult Edit(int id)
        {
          Persona  MiPersona = ContextoPersona.Persona.Find(id);
            return View(MiPersona);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Persona model)
        {




            ContextoPersona.Persona.Attach(model);
            ContextoPersona.Entry(model).State = EntityState.Modified;
            ContextoPersona.SaveChanges();

            ContextoPersona.SaveChanges();
            return RedirectToAction("List");
        }

        // GET: PersonaController/Delete/5
        public ActionResult List()
        {
            IEnumerable<Persona> ListaPersonas = ContextoPersona.Persona.ToList();
            return View(ListaPersonas); 
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Persona MiPersona = ContextoPersona.Persona.Find(id);
       
                return View(MiPersona);
            
        }
        // POST: PersonaController/Delete/5
        [HttpPost]

        public ActionResult Delete(Persona model)
        {

            Persona MiPersona = ContextoPersona.Persona.Find(model.id);
            ContextoPersona.Persona.Remove(MiPersona);
            ContextoPersona.SaveChanges();

            return View();
        }
    }
}
