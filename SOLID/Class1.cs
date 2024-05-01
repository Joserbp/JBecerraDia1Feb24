using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //Usuario BL
    //Usuario ML
    //Rol BL

    //Empleado 
    //ConsultarSalario


    //Descuentos
    //ObtenerDescuantos

    //Factura
    //GenerarFactura

    //S single responsability
    public class Transporte
    {
        public string Placa { get; set; }
        public string Color { get; set; }
        public byte Llantas { get; set; }

        public void EntregarPaquete()
        {
        }

        public void Recolectar()
        {
        }
    }
    public class Resarvacion
    {
        public void Reservar()
        {
        }
    }
    //O open/close
    //open  --- Extension
    //Close --- Modificaciones

    public partial class Empleado
    {
        public int IdEmplado { get; set; }
        public string NombreEmpleado { get; set; }
    }
    public partial class Empleado
    {
        public string NumeroEmpleado { get; set; }
    }
    public partial class Empleado
    {
        public void Add()
        {

        }
    }
    public partial class Empleado
    {
        public void Update()
        {

        }
    }
    public partial class Empleado
    {
        public void Delete()
        {

        }
    }


    //L Liskov
    //CLASE HIJA PUEDE SER SUSTITUIDA POR UNA CLASE PADRE

    public class Persona: Empleado
    {
        public string NombrePersona { get; set; }
    }
    public class Class1
    {


   

        //I Intefaces

        //D Dependency

    }
}
