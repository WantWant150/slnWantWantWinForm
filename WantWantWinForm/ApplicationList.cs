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
    
    public partial class ApplicationList
    {
        public Nullable<int> ResumeID { get; set; }
        public int ApplicationListID { get; set; }
        public Nullable<int> CaseID { get; set; }
        public Nullable<int> CaseStatusID { get; set; }
        public Nullable<int> RatingID { get; set; }
    
        public virtual CaseStatusList CaseStatusList { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Resume Resume { get; set; }
        public virtual TaskList TaskList { get; set; }
    }
}
