using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("MeOH_Wash_Column")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class MeOH_Wash_Column
    { 
        public MeOH_Wash_Column() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
