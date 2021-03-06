// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LeapDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UniRx;
    
    
    public partial class MenuButtonGroup : ReactiveGroup<MenuButton> {
        
        private IEcsComponentManagerOf<Button> _ButtonManager;
        
        private IEcsComponentManagerOf<MainButton> _MainButtonManager;
        
        private int lastEntityId;
        
        private Button Button;
        
        private MainButton MainButton;
        
        public IEcsComponentManagerOf<Button> ButtonManager {
            get {
                return _ButtonManager;
            }
            set {
                _ButtonManager = value;
            }
        }
        
        public IEcsComponentManagerOf<MainButton> MainButtonManager {
            get {
                return _MainButtonManager;
            }
            set {
                _MainButtonManager = value;
            }
        }
        
        public override System.Collections.Generic.IEnumerable<UniRx.IObservable<int>> Install(uFrame.ECS.IComponentSystem componentSystem) {
            ButtonManager = componentSystem.RegisterComponent<Button>();
            yield return ButtonManager.CreatedObservable.Select(_=>_.EntityId);;
            yield return ButtonManager.RemovedObservable.Select(_=>_.EntityId);;
            MainButtonManager = componentSystem.RegisterComponent<MainButton>();
            yield return MainButtonManager.CreatedObservable.Select(_=>_.EntityId);;
            yield return MainButtonManager.RemovedObservable.Select(_=>_.EntityId);;
        }
        
        public override bool Match(int entityId) {
            lastEntityId = entityId;
            if ((Button = ButtonManager[entityId]) == null) {
                return false;
            }
            if ((MainButton = MainButtonManager[entityId]) == null) {
                return false;
            }
            return true;
        }
        
        public override MenuButton Select() {
            var item = new MenuButton();;
            item.EntityId = lastEntityId;
            item.Button = Button;
            item.MainButton = MainButton;
            return item;
        }
    }
}
