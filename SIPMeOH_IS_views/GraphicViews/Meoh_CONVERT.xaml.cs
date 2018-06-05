using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("Meoh_CONVERT")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Meoh_CONVERT
    { 
        public Meoh_CONVERT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
