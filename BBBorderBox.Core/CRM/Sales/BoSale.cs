using BBBorderBox.Entity.Data.Sales;
using BBBorderBox.Data.CRM.Sales;

namespace BBBorderBox.Core.CRM.Sales
{
    public class BoSale
    {
        #region Patron de Diseño
        private static BoSale _instance;
        private static readonly object _instanceLock = new object();
        public static BoSale Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            _instance = new BoSale();
                    }
                }
                return _instance;
            }
        }
        #endregion
        public async Task<Sale> GetSale(long id)
        {
            var get = await DaSale.Instance.GetSale(id);
            return get;
        }
        public async Task<Sale> PostBotIntegrationAsync(Sale model)
        {
            var Result = await DaSale.Instance.PostSaleAsync(model);
            return Result;
        }
    }
}
