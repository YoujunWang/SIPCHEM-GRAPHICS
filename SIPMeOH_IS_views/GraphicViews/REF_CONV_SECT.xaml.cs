using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("REF_CONV_SECT")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class REF_CONV_SECT
    { 
        public REF_CONV_SECT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
