using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PStest.Models
{
    public class InventoryItem
    {
        public string Model { get; set; }
        public string Description {get; set;}
        public int MinQuantity {get; set;}
        public string PartNumber { get; set; }

    }
}