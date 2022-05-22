using BBBorderBox.Data.Data;
using BBBorderBox.Entity.Data.Sales;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBorderBox.Data.CRM.Sales
{
    public class DaSale
    {
        private readonly BBBorderBoxContext _context;
        #region Patron de Diseño
        private static DaSale _instance;
        private static readonly object _instanceLock = new object();
        public static DaSale Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            _instance = new DaSale();
                    }
                }
                return _instance;
            }
        }
        #endregion
        public DaSale() : this(new BBBorderBoxContext(new DbContextOptions<BBBorderBoxContext>())) { }
        public DaSale(BBBorderBoxContext context)
        {
            _context = context;
        }
        public async Task<Sale> GetSale(long id)
        {
            var consult = await _context.Sales.FindAsync(id);
            return consult;
        }
        public async Task<Sale> PostSaleAsync(Sale model)
        {
            await _context.Sales.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
