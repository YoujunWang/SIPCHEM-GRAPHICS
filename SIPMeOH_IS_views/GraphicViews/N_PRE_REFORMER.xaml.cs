using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_PRE_REFORMER")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_PRE_REFORMER
    { 
        public N_PRE_REFORMER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
