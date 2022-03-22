using System.ComponentModel.DataAnnotations;

namespace BBBorderBox.Api.Models
{
    public class Package
    {
        public long PackageId { get; set; }
        public long SaleId { get; set; }
        public string CodigoRastreo { get; set; }
        public decimal Dimentions { get; set; }
        public decimal Weigth { get; set; }
        public int PackagesTypeId { get; set; }
    }
}
