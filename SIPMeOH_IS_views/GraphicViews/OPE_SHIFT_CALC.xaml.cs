using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("OPE_SHIFT_CALC")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class OPE_SHIFT_CALC
    { 
        public OPE_SHIFT_CALC() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
