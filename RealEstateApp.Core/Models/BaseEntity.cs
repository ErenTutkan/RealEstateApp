using RealEstateApp.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Models
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; } =DateTime.Now;
        public DateTime UpdateTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

    }
}
