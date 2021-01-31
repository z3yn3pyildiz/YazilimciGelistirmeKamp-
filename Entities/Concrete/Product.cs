﻿using Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CatagoryId { get; set; }
        public String ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
