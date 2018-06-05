using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("N_REF_COLUMN")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class N_REF_COLUMN
    { 
        public N_REF_COLUMN() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
