using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    class Suppliers
    {
        private int id;
        private String companyName;
        private String contactName;
        private String address;
        private String city;
        private String region;
        private String codPostal;
        private String contactTitle;
        private String country;
        private String phone;
        private String fax;
        private String homePage;

        public int Id { get => id; set => id = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Region { get => region; set => region = value; }
        public string CodPostal { get => codPostal; set => codPostal = value; }
        public string ContactTitle { get => contactTitle; set => contactTitle = value; }
        public string Country { get => country; set => country = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Fax { get => fax; set => fax = value; }
        public string HomePage { get => homePage; set => homePage = value; }
    }
}
