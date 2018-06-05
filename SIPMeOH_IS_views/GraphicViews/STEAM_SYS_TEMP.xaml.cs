using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace SIPMeOH_IS_views 
{ 
    [ExportSynoptic("STEAM_SYS_TEMP")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class STEAM_SYS_TEMP
    { 
        public STEAM_SYS_TEMP() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
