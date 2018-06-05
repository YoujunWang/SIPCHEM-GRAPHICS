using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_SD_OTR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_SD_OTR
    { 
        public N_SD_OTR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
