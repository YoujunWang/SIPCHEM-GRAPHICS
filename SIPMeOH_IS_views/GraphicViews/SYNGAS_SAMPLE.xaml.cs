using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("SYNGAS_SAMPLE")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SYNGAS_SAMPLE
    { 
        public SYNGAS_SAMPLE() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
