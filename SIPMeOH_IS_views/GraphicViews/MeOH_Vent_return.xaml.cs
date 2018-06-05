using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("MeOH_Vent_return")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class MeOH_Vent_return
    { 
        public MeOH_Vent_return() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
