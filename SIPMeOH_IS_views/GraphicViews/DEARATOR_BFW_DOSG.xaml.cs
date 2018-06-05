using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("DEARATOR_BFW_DOSG")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DEARATOR_BFW_DOSG
    { 
        public DEARATOR_BFW_DOSG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
