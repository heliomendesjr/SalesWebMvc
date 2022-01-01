using System.Collections.Generic;


namespace SalesWebMvc1.Models.ViewModels
{
    public class SallerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
