using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("MeOH_Wash_Column_PES_Reset")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class MeOH_Wash_Column_PES_Reset
    { 
        public MeOH_Wash_Column_PES_Reset() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
