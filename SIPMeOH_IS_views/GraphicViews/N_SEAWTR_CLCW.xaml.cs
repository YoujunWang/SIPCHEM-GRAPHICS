using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_SEAWTR_CLCW")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_SEAWTR_CLCW
    { 
        public N_SEAWTR_CLCW() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
