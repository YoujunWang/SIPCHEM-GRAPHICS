using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("STEAM_CARBON_R_CONTROL")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class STEAM_CARBON_R_CONTROL
    { 
        public STEAM_CARBON_R_CONTROL() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
