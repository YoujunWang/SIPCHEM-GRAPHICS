using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("LIGHT_END_COLUMN")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class LIGHT_END_COLUMN
    { 
        public LIGHT_END_COLUMN() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
