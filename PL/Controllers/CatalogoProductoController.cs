using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class CatalogoProductoController : Controller
    {
        // GET: CatalogoProducto
        public ActionResult GetAll()
        {
            Proyecto_ENT.Exa_CatalogoProducto catalogoProducto = new Proyecto_ENT.Exa_CatalogoProducto();
            CatalogoProductoService.Exa_CatalogoProductoClient catalogoProductoClient = new CatalogoProductoService.Exa_CatalogoProductoClient();
            Proyecto_ENT.Result result = catalogoProductoClient.GetAll();
            if (result.Correct)
            {
                catalogoProducto.CatalogoProductos = result.Objects;
                return View(catalogoProducto);
            }
            else
            {
                return View(catalogoProducto);
            }
        }
        [HttpGet]
        public ActionResult Form(int? IdProducto)
        {
            Proyecto_ENT.Exa_CatalogoProducto catalogoProducto = new Proyecto_ENT.Exa_CatalogoProducto();
            if (IdProducto == null)
            {
                return View();
            }
            else
            {
                CatalogoProductoService.Exa_CatalogoProductoClient catalogoProductoClient = new CatalogoProductoService.Exa_CatalogoProductoClient();
                Proyecto_ENT.Result result = catalogoProductoClient.GetById(IdProducto.Value);
                if (result.Correct)
                {
                    catalogoProducto = (Proyecto_ENT.Exa_CatalogoProducto)result.Object;
                    return View(catalogoProducto);
                }
                else
                {
                    ViewBag.Message = "Error al consultar la informacion";
                    return View("Modal");
                }
            }
        }
        [HttpPost]
        public ActionResult Form(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto)
        {
            Proyecto_ENT.Result result = new Proyecto_ENT.Result();
            if (catalogoProducto.IdProducto == 0)
            {
                CatalogoProductoService.Exa_CatalogoProductoClient catalogoProductoClient = new CatalogoProductoService.Exa_CatalogoProductoClient();
                result = catalogoProductoClient.Add(catalogoProducto);
                if (result.Correct)
                {
                    ViewBag.Message = "Se inserto el registro";
                }
                else
                {
                    ViewBag.Message = "Error al insertar la informacion";
                }
                return View("Modal");
            }
            else
            {
                CatalogoProductoService.Exa_CatalogoProductoClient catalogoProductoClient = new CatalogoProductoService.Exa_CatalogoProductoClient();
                result = catalogoProductoClient.Update(catalogoProducto);
                if (result.Correct)
                {
                    ViewBag.Message = "Se actualizo el registro";
                }
                else
                {
                    ViewBag.Message = "Error al actualizar la informacion";
                }
                return View("Modal");
            }
        }
    }
}