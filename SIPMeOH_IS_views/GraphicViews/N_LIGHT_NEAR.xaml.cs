using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_LIGHT_NEAR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_LIGHT_NEAR
    { 
        public N_LIGHT_NEAR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
