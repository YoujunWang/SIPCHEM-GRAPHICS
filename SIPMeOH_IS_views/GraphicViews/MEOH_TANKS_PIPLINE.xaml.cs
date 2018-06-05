using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("MEOH_TANKS_PIPLINE")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class MEOH_TANKS_PIPLINE
    { 
        public MEOH_TANKS_PIPLINE() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
