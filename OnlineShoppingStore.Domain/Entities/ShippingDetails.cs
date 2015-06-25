using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required (ErrorMessage = "Please Enter A Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter The First Address Line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please Enter A City Name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter A State Name")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please Enter A Country Name")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
