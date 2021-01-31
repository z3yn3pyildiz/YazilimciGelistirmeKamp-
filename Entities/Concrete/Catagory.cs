using Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Catagory:IEntity

    {
        public int CatagoryId { get; set; }
        public String CatagoryName { get; set; }

    }
}
