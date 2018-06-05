using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_INTERLOCK_LIST")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_INTERLOCK_LIST
    { 
        public N_INTERLOCK_LIST() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
