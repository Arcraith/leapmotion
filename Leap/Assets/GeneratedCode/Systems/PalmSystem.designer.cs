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
    using LeapDB;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    public partial class PalmSystemBase : uFrame.ECS.EcsSystem, uFrame.ECS.ISystemUpdate {
        
        private IEcsComponentManagerOf<ExcerciseManagerComponent> _ExcerciseManagerComponentManager;
        
        private IEcsComponentManagerOf<EasyButton> _EasyButtonManager;
        
        private IEcsComponentManagerOf<IndexFingerComponent> _IndexFingerComponentManager;
        
        private IEcsComponentManagerOf<MediumButton> _MediumButtonManager;
        
        private IEcsComponentManagerOf<MenuButton> _MenuButtonManager;
        
        private IEcsComponentManagerOf<Difficulty> _DifficultyManager;
        
        private IEcsComponentManagerOf<MainButton> _MainButtonManager;
        
        private IEcsComponentManagerOf<HardButton> _HardButtonManager;
        
        private IEcsComponentManagerOf<HandComponent> _HandComponentManager;
        
        private IEcsComponentManagerOf<Easy> _EasyManager;
        
        private IEcsComponentManagerOf<Button> _ButtonManager;
        
        private IEcsComponentManagerOf<Hard> _HardManager;
        
        private IEcsComponentManagerOf<Menu> _MenuManager;
        
        private IEcsComponentManagerOf<Medium> _MediumManager;
        
        public IEcsComponentManagerOf<ExcerciseManagerComponent> ExcerciseManagerComponentManager {
            get {
                return _ExcerciseManagerComponentManager;
            }
            set {
                _ExcerciseManagerComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<EasyButton> EasyButtonManager {
            get {
                return _EasyButtonManager;
            }
            set {
                _EasyButtonManager = value;
            }
        }
        
        public IEcsComponentManagerOf<IndexFingerComponent> IndexFingerComponentManager {
            get {
                return _IndexFingerComponentManager;
            }
            set {
                _IndexFingerComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<MediumButton> MediumButtonManager {
            get {
                return _MediumButtonManager;
            }
            set {
                _MediumButtonManager = value;
            }
        }
        
        public IEcsComponentManagerOf<MenuButton> MenuButtonManager {
            get {
                return _MenuButtonManager;
            }
            set {
                _MenuButtonManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Difficulty> DifficultyManager {
            get {
                return _DifficultyManager;
            }
            set {
                _DifficultyManager = value;
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
        
        public IEcsComponentManagerOf<HardButton> HardButtonManager {
            get {
                return _HardButtonManager;
            }
            set {
                _HardButtonManager = value;
            }
        }
        
        public IEcsComponentManagerOf<HandComponent> HandComponentManager {
            get {
                return _HandComponentManager;
            }
            set {
                _HandComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Easy> EasyManager {
            get {
                return _EasyManager;
            }
            set {
                _EasyManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Button> ButtonManager {
            get {
                return _ButtonManager;
            }
            set {
                _ButtonManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Hard> HardManager {
            get {
                return _HardManager;
            }
            set {
                _HardManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Menu> MenuManager {
            get {
                return _MenuManager;
            }
            set {
                _MenuManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Medium> MediumManager {
            get {
                return _MediumManager;
            }
            set {
                _MediumManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            ExcerciseManagerComponentManager = ComponentSystem.RegisterComponent<ExcerciseManagerComponent>(34);
            EasyButtonManager = ComponentSystem.RegisterGroup<EasyButtonGroup,EasyButton>();
            IndexFingerComponentManager = ComponentSystem.RegisterComponent<IndexFingerComponent>(2);
            MediumButtonManager = ComponentSystem.RegisterGroup<MediumButtonGroup,MediumButton>();
            MenuButtonManager = ComponentSystem.RegisterGroup<MenuButtonGroup,MenuButton>();
            DifficultyManager = ComponentSystem.RegisterComponent<Difficulty>(31);
            MainButtonManager = ComponentSystem.RegisterComponent<MainButton>(30);
            HardButtonManager = ComponentSystem.RegisterGroup<HardButtonGroup,HardButton>();
            HandComponentManager = ComponentSystem.RegisterComponent<HandComponent>(1);
            EasyManager = ComponentSystem.RegisterComponent<Easy>(8);
            ButtonManager = ComponentSystem.RegisterComponent<Button>(7);
            HardManager = ComponentSystem.RegisterComponent<Hard>(11);
            MenuManager = ComponentSystem.RegisterComponent<Menu>(20);
            MediumManager = ComponentSystem.RegisterComponent<Medium>(10);
        }
        
        protected virtual void PalmSystemUpdateHandler(MenuButton group) {
            var handler = new PalmSystemUpdateHandler();
            handler.System = this;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void PalmSystemUpdateFilter() {
            var MenuButtonItems = MenuButtonManager.Components;
            for (var MenuButtonIndex = 0
            ; MenuButtonIndex < MenuButtonItems.Count; MenuButtonIndex++
            ) {
                if (!MenuButtonItems[MenuButtonIndex].Enabled) {
                    continue;
                }
                this.PalmSystemUpdateHandler(MenuButtonItems[MenuButtonIndex]);
            }
        }
        
        public virtual void SystemUpdate() {
            PalmSystemUpdateFilter();
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("17a02112-f561-436b-bd2f-a9742f63877e")]
    public partial class PalmSystem : PalmSystemBase {
        
        private static PalmSystem _Instance;
        
        public PalmSystem() {
            Instance = this;
        }
        
        public static PalmSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
