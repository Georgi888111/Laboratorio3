using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpLinq
{
    class Conexion
    {
        DataClasesDataContext dataContext = new DataClasesDataContext();


        public IEnumerable<Employees> traeEmpleados()
        {
            IEnumerable<Employees> empleados;
            try
            {
                empleados = from emple in dataContext.Employees select emple;
                return empleados;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public IEnumerable<Employees> traeEmpleadosCiudad()
        {
            IEnumerable<Employees> empleados;
            try
            {
                empleados = from emple in dataContext.Employees where emple.City =="London" select emple;
                return empleados;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public IEnumerable<Employees> traeEmpleadosCiudadTitle()
        {
            IEnumerable<Employees> empleados;
            try
            {
                empleados = from emple in dataContext.Employees where emple.City == "London" && emple.TitleOfCourtesy == "Mr." select emple;
                return empleados;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public IEnumerable<Employees> traeEmpleadosCiudadUsa()
        {
            IEnumerable<Employees> empleados;
            try
            {
                empleados = from emple in dataContext.Employees where emple.Country == "USA" || emple.City =="Seattle" select emple;
                return empleados;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public IEnumerable<Employees> traeEmpleadosCiudadTitleSales()
        {
            IEnumerable<Employees> empleados;
            try
            {
                empleados = from emple in dataContext.Employees where SqlMethods .Like(emple.Title,"Sales%") select emple;
                return empleados;
            }
            catch (Exception ex)
            {
                throw ex;
            }


       }


        public IEnumerable<Customers> customersPorCity()
        {
            IEnumerable<Customers> clientes;
            try
            {
                clientes = from clien in dataContext.Customers orderby clien.City ascending select clien;
                return clientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
          public IEnumerable<Suppliers> todosProveedores()
        {
            IEnumerable<Suppliers> proveedores;
            try
            {
                proveedores = from prove in dataContext.Suppliers select prove;
                return proveedores;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public void agregaProveedor(Supplier sup)
        {
            try
            {

                Suppliers suppliers = new Suppliers();
                suppliers.CompanyName = sup.Nombre;
                dataContext.Suppliers.InsertOnSubmit(suppliers);
                dataContext.SubmitChanges();
                MessageBox.Show("Proveedor agregado con exito");   
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public void modificaProveedor(Supplier sup)
        {
            try
            {

                var query = (from prove in dataContext.Suppliers
                             where prove.SupplierID == sup.Id
                             select prove).FirstOrDefault();

                query.CompanyName = sup.Nombre;


                dataContext.SubmitChanges();
                MessageBox.Show("Proveedor modificado con exito");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void eliminaProveedor(Supplier sup)
        {
            try
            {

                var query = (from prove in dataContext.Suppliers
                             where prove.SupplierID == sup.Id
                             select prove).FirstOrDefault();
                    

                dataContext.Suppliers.DeleteOnSubmit(query);
                dataContext.SubmitChanges();
                MessageBox.Show("Proveedor eliminado con exito");


              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
        }

