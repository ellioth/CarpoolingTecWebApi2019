﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarPoolingTecWebApi22019.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CARPOOLINGTECWebApi2019_dbEntities : DbContext
    {
        public CARPOOLINGTECWebApi2019_dbEntities()
            : base("name=CARPOOLINGTECWebApi2019_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AMIGO> AMIGOS { get; set; }
        public virtual DbSet<CARRO> CARROes { get; set; }
        public virtual DbSet<CATEGORIA> CATEGORIAS { get; set; }
        public virtual DbSet<OBJETOS_INTERCAMBIO> OBJETOS_INTERCAMBIO { get; set; }
        public virtual DbSet<TELEFONO> TELEFONOS { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
        public virtual DbSet<VIAJE> VIAJES { get; set; }
        public virtual DbSet<VIAJESXUSUARIO> VIAJESXUSUARIOs { get; set; }
        public virtual DbSet<NOTIFICACIONE> NOTIFICACIONES { get; set; }
    
        public virtual int usp_DelAmigo(Nullable<int> userID, Nullable<int> amigoID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var amigoIDParameter = amigoID.HasValue ?
                new ObjectParameter("amigoID", amigoID) :
                new ObjectParameter("amigoID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DelAmigo", userIDParameter, amigoIDParameter);
        }
    
        public virtual int usp_DelCarro(string placa)
        {
            var placaParameter = placa != null ?
                new ObjectParameter("placa", placa) :
                new ObjectParameter("placa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DelCarro", placaParameter);
        }
    
        public virtual int usp_DelCategoria(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DelCategoria", idParameter);
        }
    
        public virtual int usp_DelTelefono(string telefono, Nullable<int> userID)
        {
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DelTelefono", telefonoParameter, userIDParameter);
        }
    
        public virtual int usp_DelUsuario(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DelUsuario", idParameter);
        }
    
        public virtual ObjectResult<usp_GetAmigos_Result> usp_GetAmigos(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAmigos_Result>("usp_GetAmigos", userIDParameter);
        }
    
        public virtual ObjectResult<usp_GetCantPassViaje_Result> usp_GetCantPassViaje(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetCantPassViaje_Result>("usp_GetCantPassViaje", userIDParameter);
        }
    
        public virtual ObjectResult<usp_GetCarro_Result> usp_GetCarro(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetCarro_Result>("usp_GetCarro", userIDParameter);
        }
    
        public virtual ObjectResult<usp_GetCategorias_Result> usp_GetCategorias()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetCategorias_Result>("usp_GetCategorias");
        }
    
        public virtual ObjectResult<usp_GetInfoViaje_Result> usp_GetInfoViaje(Nullable<int> viajeID)
        {
            var viajeIDParameter = viajeID.HasValue ?
                new ObjectParameter("viajeID", viajeID) :
                new ObjectParameter("viajeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetInfoViaje_Result>("usp_GetInfoViaje", viajeIDParameter);
        }
    
        public virtual ObjectResult<usp_GetObjIntercambios_Result> usp_GetObjIntercambios(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetObjIntercambios_Result>("usp_GetObjIntercambios", userIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_GetPuntosGastados(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_GetPuntosGastados", userIDParameter);
        }
    
        public virtual ObjectResult<string> usp_GetTelefonos(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_GetTelefonos", userIDParameter);
        }
    
        public virtual ObjectResult<usp_GetUsuario_Result> usp_GetUsuario(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetUsuario_Result>("usp_GetUsuario", idParameter);
        }
    
        public virtual ObjectResult<usp_GetViajes_Result> usp_GetViajes(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetViajes_Result>("usp_GetViajes", userIDParameter);
        }
    
        public virtual int usp_PostAmigo(Nullable<int> userID, Nullable<int> amigoID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var amigoIDParameter = amigoID.HasValue ?
                new ObjectParameter("amigoID", amigoID) :
                new ObjectParameter("amigoID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PostAmigo", userIDParameter, amigoIDParameter);
        }
    
        public virtual int usp_PostCarro(string placa, string marca, string modelo, Nullable<int> pas_cant, Nullable<int> userID)
        {
            var placaParameter = placa != null ?
                new ObjectParameter("placa", placa) :
                new ObjectParameter("placa", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("marca", marca) :
                new ObjectParameter("marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("modelo", modelo) :
                new ObjectParameter("modelo", typeof(string));
    
            var pas_cantParameter = pas_cant.HasValue ?
                new ObjectParameter("pas_cant", pas_cant) :
                new ObjectParameter("pas_cant", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PostCarro", placaParameter, marcaParameter, modeloParameter, pas_cantParameter, userIDParameter);
        }
    
        public virtual int usp_PostCategoria(string nombre, Nullable<int> puntaje, Nullable<int> umbral, Nullable<int> umbralPmes)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var puntajeParameter = puntaje.HasValue ?
                new ObjectParameter("puntaje", puntaje) :
                new ObjectParameter("puntaje", typeof(int));
    
            var umbralParameter = umbral.HasValue ?
                new ObjectParameter("umbral", umbral) :
                new ObjectParameter("umbral", typeof(int));
    
            var umbralPmesParameter = umbralPmes.HasValue ?
                new ObjectParameter("umbralPmes", umbralPmes) :
                new ObjectParameter("umbralPmes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PostCategoria", nombreParameter, puntajeParameter, umbralParameter, umbralPmesParameter);
        }
    
        public virtual int usp_PostObjIntercambio(Nullable<int> id, Nullable<int> userID, string nombre, Nullable<int> cantidad, Nullable<int> puntaje, Nullable<int> precio, string fecha)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            var puntajeParameter = puntaje.HasValue ?
                new ObjectParameter("puntaje", puntaje) :
                new ObjectParameter("puntaje", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(int));
    
            var fechaParameter = fecha != null ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PostObjIntercambio", idParameter, userIDParameter, nombreParameter, cantidadParameter, puntajeParameter, precioParameter, fechaParameter);
        }
    
        public virtual int usp_PostTelefono(string telefono, Nullable<int> userID)
        {
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PostTelefono", telefonoParameter, userIDParameter);
        }
    
        public virtual int usp_PostUsuario(Nullable<int> id, string nombre, string apellido1, string apellido2, string correo, string rol, Nullable<int> estadoCuenta, Nullable<int> categoria)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellido1Parameter = apellido1 != null ?
                new ObjectParameter("apellido1", apellido1) :
                new ObjectParameter("apellido1", typeof(string));
    
            var apellido2Parameter = apellido2 != null ?
                new ObjectParameter("apellido2", apellido2) :
                new ObjectParameter("apellido2", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var rolParameter = rol != null ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(string));
    
            var estadoCuentaParameter = estadoCuenta.HasValue ?
                new ObjectParameter("estadoCuenta", estadoCuenta) :
                new ObjectParameter("estadoCuenta", typeof(int));
    
            var categoriaParameter = categoria.HasValue ?
                new ObjectParameter("categoria", categoria) :
                new ObjectParameter("categoria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PostUsuario", idParameter, nombreParameter, apellido1Parameter, apellido2Parameter, correoParameter, rolParameter, estadoCuentaParameter, categoriaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_PostViajes(Nullable<int> choferID, string fecha, string placaCarro)
        {
            var choferIDParameter = choferID.HasValue ?
                new ObjectParameter("choferID", choferID) :
                new ObjectParameter("choferID", typeof(int));
    
            var fechaParameter = fecha != null ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(string));
    
            var placaCarroParameter = placaCarro != null ?
                new ObjectParameter("placaCarro", placaCarro) :
                new ObjectParameter("placaCarro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_PostViajes", choferIDParameter, fechaParameter, placaCarroParameter);
        }
    
        public virtual int usp_PutCategoria(Nullable<int> id, string nombre, Nullable<int> puntaje, Nullable<int> umbral, Nullable<int> umbralPmes)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var puntajeParameter = puntaje.HasValue ?
                new ObjectParameter("puntaje", puntaje) :
                new ObjectParameter("puntaje", typeof(int));
    
            var umbralParameter = umbral.HasValue ?
                new ObjectParameter("umbral", umbral) :
                new ObjectParameter("umbral", typeof(int));
    
            var umbralPmesParameter = umbralPmes.HasValue ?
                new ObjectParameter("umbralPmes", umbralPmes) :
                new ObjectParameter("umbralPmes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PutCategoria", idParameter, nombreParameter, puntajeParameter, umbralParameter, umbralPmesParameter);
        }
    
        public virtual int usp_PutNoParqueo(Nullable<int> id, Nullable<int> parqueo)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var parqueoParameter = parqueo.HasValue ?
                new ObjectParameter("parqueo", parqueo) :
                new ObjectParameter("parqueo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PutNoParqueo", idParameter, parqueoParameter);
        }
    
        public virtual int usp_PutPuntaje(Nullable<int> viajeID, Nullable<int> userID, Nullable<int> puntaje)
        {
            var viajeIDParameter = viajeID.HasValue ?
                new ObjectParameter("viajeID", viajeID) :
                new ObjectParameter("viajeID", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var puntajeParameter = puntaje.HasValue ?
                new ObjectParameter("puntaje", puntaje) :
                new ObjectParameter("puntaje", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PutPuntaje", viajeIDParameter, userIDParameter, puntajeParameter);
        }
    
        public virtual int usp_PutUsuario(Nullable<int> id, string nombre, string apellido1, string apellido2, string correo, string tipo, Nullable<int> estadoCuenta, Nullable<int> categoria)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellido1Parameter = apellido1 != null ?
                new ObjectParameter("apellido1", apellido1) :
                new ObjectParameter("apellido1", typeof(string));
    
            var apellido2Parameter = apellido2 != null ?
                new ObjectParameter("apellido2", apellido2) :
                new ObjectParameter("apellido2", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            var estadoCuentaParameter = estadoCuenta.HasValue ?
                new ObjectParameter("estadoCuenta", estadoCuenta) :
                new ObjectParameter("estadoCuenta", typeof(int));
    
            var categoriaParameter = categoria.HasValue ?
                new ObjectParameter("categoria", categoria) :
                new ObjectParameter("categoria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PutUsuario", idParameter, nombreParameter, apellido1Parameter, apellido2Parameter, correoParameter, tipoParameter, estadoCuentaParameter, categoriaParameter);
        }
    
        public virtual int usp_PostViajesXusuario(Nullable<int> userID, Nullable<int> viajeID, Nullable<int> codigoViaje)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var viajeIDParameter = viajeID.HasValue ?
                new ObjectParameter("viajeID", viajeID) :
                new ObjectParameter("viajeID", typeof(int));
    
            var codigoViajeParameter = codigoViaje.HasValue ?
                new ObjectParameter("codigoViaje", codigoViaje) :
                new ObjectParameter("codigoViaje", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PostViajesXusuario", userIDParameter, viajeIDParameter, codigoViajeParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_GetPuntosGanados(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_GetPuntosGanados", userIDParameter);
        }
    
        public virtual ObjectResult<usp_GetAllUser_Result> usp_GetAllUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllUser_Result>("usp_GetAllUser");
        }
    
        public virtual int usp_DelNotifi(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DelNotifi", iDParameter);
        }
    
        public virtual ObjectResult<usp_GetNotifi_Result> usp_GetNotifi(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetNotifi_Result>("usp_GetNotifi", userIDParameter);
        }
    
        public virtual int usp_PostNotifi(Nullable<int> userID, Nullable<int> type, string info)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(int));
    
            var infoParameter = info != null ?
                new ObjectParameter("info", info) :
                new ObjectParameter("info", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_PostNotifi", userIDParameter, typeParameter, infoParameter);
        }
    }
}
