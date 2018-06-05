using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SYNGAS_REACTOR_OV")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SYNGAS_REACTOR_OV
    { 
        public SYNGAS_REACTOR_OV() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
