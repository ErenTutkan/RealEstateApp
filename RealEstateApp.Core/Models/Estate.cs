using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Models
{
    public class Estate:IEntity
    {
        public string Title { get; set; }
        public int BedSize { get; set; }
        public int BathSize { get; set; }
        public string? Address { get; set; }
        public string? Details { get; set; }
        public string RoomSize { get; set; }
        public Image Image { get; set; }

    }
}
