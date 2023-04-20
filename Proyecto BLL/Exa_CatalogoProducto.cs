using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BLL
{
    public class Exa_CatalogoProducto
    {
        public static Proyecto_ENT.Result Add(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto)
        {
            Proyecto_ENT.Result result = new Proyecto_ENT.Result();
            try
            {
                using (Proyecto_DAL.JSanchezENITMAEntities context = new Proyecto_DAL.JSanchezENITMAEntities())
                {
                    int query = context.sp_InsCatalogoProd(catalogoProducto.Descripcion);
                    if (result.Correct)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al insertar";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static Proyecto_ENT.Result Update(Proyecto_ENT.Exa_CatalogoProducto catalogoProducto)
        {
            Proyecto_ENT.Result result = new Proyecto_ENT.Result();
            try
            {
                using (Proyecto_DAL.JSanchezENITMAEntities context = new Proyecto_DAL.JSanchezENITMAEntities())
                {
                    int query = context.sp_UpdateCatalogoProducto(catalogoProducto.IdProducto, catalogoProducto.Descripcion);
                    if (result.Correct)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al actualizar";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static Proyecto_ENT.Result GetAll()
        {
            Proyecto_ENT.Result result = new Proyecto_ENT.Result();
            try
            {
                using (Proyecto_DAL.JSanchezENITMAEntities context = new Proyecto_DAL.JSanchezENITMAEntities())
                {
                    var query = context.sp_GetAllCatalogoProd().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            Proyecto_ENT.Exa_CatalogoProducto catalogoProducto = new Proyecto_ENT.Exa_CatalogoProducto();

                            catalogoProducto.IdProducto = obj.IdProducto;
                            catalogoProducto.Descripcion = obj.Descripcion;
                            catalogoProducto.IdUsuario = obj.IdUsuario.Value;
                            catalogoProducto.FechaCreacion = obj.FechaCreacion.ToString();

                            result.Objects.Add(catalogoProducto);
                        }
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static Proyecto_ENT.Result GetById(int IdProducto)
        {
            Proyecto_ENT.Result result = new Proyecto_ENT.Result();
            try
            {
                using (Proyecto_DAL.JSanchezENITMAEntities context = new Proyecto_DAL.JSanchezENITMAEntities())
                {
                    var query = context.sp_GetByIdCatalogoProd(IdProducto).AsEnumerable().FirstOrDefault();

                    if (query != null)
                    {
                        result.Object = new List<object>();
                        var obj = query;

                        Proyecto_ENT.Exa_CatalogoProducto catalogoProducto = new Proyecto_ENT.Exa_CatalogoProducto();

                        catalogoProducto.IdProducto = obj.IdProducto;
                        catalogoProducto.Descripcion = obj.Descripcion;
                        catalogoProducto.IdUsuario = obj.IdUsuario.Value;
                        catalogoProducto.FechaCreacion = obj.FechaCreacion.ToString();

                        result.Object = catalogoProducto;
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
