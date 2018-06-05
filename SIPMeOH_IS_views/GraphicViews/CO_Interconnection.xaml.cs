using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("CO_Interconnection")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class CO_Interconnection
    { 
        public CO_Interconnection() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
