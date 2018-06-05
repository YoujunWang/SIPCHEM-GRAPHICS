using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_FUSEL_OIL")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_FUSEL_OIL
    { 
        public N_FUSEL_OIL() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
