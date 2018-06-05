using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SD_FG_COMPR")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SD_FG_COMPR
    { 
        public SD_FG_COMPR() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
