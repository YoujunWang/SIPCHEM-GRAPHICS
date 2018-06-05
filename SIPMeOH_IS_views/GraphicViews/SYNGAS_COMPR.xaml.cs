using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SYNGAS_COMPR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SYNGAS_COMPR
    { 
        public SYNGAS_COMPR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
