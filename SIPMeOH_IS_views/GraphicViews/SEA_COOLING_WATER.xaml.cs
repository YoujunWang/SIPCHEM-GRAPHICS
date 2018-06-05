using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SEA_COOLING_WATER")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SEA_COOLING_WATER
    { 
        public SEA_COOLING_WATER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
