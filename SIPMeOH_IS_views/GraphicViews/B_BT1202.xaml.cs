using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("B_BT1202")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class B_BT1202
    { 
        public B_BT1202() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
