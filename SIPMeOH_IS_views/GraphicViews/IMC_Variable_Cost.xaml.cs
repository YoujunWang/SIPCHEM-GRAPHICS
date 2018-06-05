using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("IMC_Variable_Cost")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class IMC_Variable_Cost
    { 
        public IMC_Variable_Cost() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
