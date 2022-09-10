using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateApp.Core.Abstract;

namespace RealEstateApp.Core.Models
{
    public class Image:BaseEntity
    {
        public string ImageUrl { get; set; }
    }
}
