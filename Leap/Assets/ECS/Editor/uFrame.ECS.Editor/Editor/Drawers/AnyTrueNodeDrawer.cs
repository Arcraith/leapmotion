namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class AnyTrueNodeDrawer : GenericNodeDrawer<AnyTrueNode,AnyTrueNodeViewModel> {
        
        public AnyTrueNodeDrawer(AnyTrueNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
