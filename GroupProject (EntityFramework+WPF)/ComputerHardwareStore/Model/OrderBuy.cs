//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerHardwareStore.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderBuy
    {
        public int ID_OrderBuy { get; set; }
        public int VendoreCode { get; set; }
        public int ID_Invoice { get; set; }
        public int QuantityProduct { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
