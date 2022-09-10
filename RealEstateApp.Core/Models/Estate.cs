using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateApp.Core.Abstract;

namespace RealEstateApp.Core.Models
{
    public class Estate:BaseEntity
    {
        public string Title { get; set; }
        public int BedSize { get; set; }
        public int BathSize { get; set; }
        public string? Address { get; set; }
        public string? Details { get; set; }
        public string RoomSize { get; set; }
        public List<Image> Images { get; set; }

    }
}
