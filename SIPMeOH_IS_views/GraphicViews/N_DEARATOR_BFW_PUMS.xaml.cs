using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_DEARATOR_BFW_PUMS")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_DEARATOR_BFW_PUMS
    { 
        public N_DEARATOR_BFW_PUMS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
