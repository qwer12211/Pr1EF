//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pr1EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int ID_Order { get; set; }
        public int ID_Customer { get; set; }
        public int ID_Burger { get; set; }
        public decimal OrderSum { get; set; }
        public string OrderStatus { get; set; }
    
        public virtual Burgers Burgers { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
