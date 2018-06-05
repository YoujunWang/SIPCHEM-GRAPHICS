using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N2_CIRCULATION")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N2_CIRCULATION
    { 
        public N2_CIRCULATION() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
