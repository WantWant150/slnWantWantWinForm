//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjWantWantWinForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int OrderdetailID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> CaseID { get; set; }
        public Nullable<int> ResumeID { get; set; }
        public Nullable<int> UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<float> Discount { get; set; }
        public Nullable<int> TopDate { get; set; }
        public string TopType { get; set; }
        public Nullable<int> UnitPoint { get; set; }
        public Nullable<int> GetPoint { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual Resume Resume { get; set; }
        public virtual TaskList TaskList { get; set; }
    }
}
