using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("FG_COMP_AND_PREH_NEW")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class FG_COMP_AND_PREH_NEW
    { 
        public FG_COMP_AND_PREH_NEW() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
