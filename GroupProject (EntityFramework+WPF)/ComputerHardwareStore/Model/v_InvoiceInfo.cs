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
    
    public partial class v_InvoiceInfo
    {
        public int Code { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
        public int Quant { get; set; }
        public decimal Price { get; set; }
        public int ID_Invoice { get; set; }
        public int ID_OrderBuy { get; set; }
    }
}
