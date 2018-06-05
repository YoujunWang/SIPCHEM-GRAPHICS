using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("REF_HDR_TUBE_TEMP")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class REF_HDR_TUBE_TEMP
    { 
        public REF_HDR_TUBE_TEMP() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
