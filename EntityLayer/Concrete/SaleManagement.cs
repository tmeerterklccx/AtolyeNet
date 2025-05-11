using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SaleManagement
    {
        [Key]
        public int SaleManagementID { get; set; }
        public string ProductName { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public string Address { get; set; }
        public bool Statu { get; set; }
    }
}
