//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoingToWorkApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpPassword { get; set; }
        public System.DateTime EmpBirth { get; set; }
        public bool IsGoingToWork { get; set; }
        public bool Authority { get; set; }
    }
}
