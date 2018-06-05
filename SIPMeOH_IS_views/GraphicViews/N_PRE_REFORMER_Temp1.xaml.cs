using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_PRE_REFORMER_Temp1")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_PRE_REFORMER_Temp1
    { 
        public N_PRE_REFORMER_Temp1() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
