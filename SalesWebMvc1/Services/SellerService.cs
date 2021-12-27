using SalesWebMvc1.Data;
using SalesWebMvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc1.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc1Context _context;
        public SellerService(SalesWebMvc1Context context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
