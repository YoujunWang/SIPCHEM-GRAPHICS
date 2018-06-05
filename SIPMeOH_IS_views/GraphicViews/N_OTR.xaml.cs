using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_OTR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_OTR
    { 
        public N_OTR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
