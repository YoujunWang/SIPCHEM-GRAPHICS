using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SD_SYNGAS_COMPR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SD_SYNGAS_COMPR
    { 
        public SD_SYNGAS_COMPR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
