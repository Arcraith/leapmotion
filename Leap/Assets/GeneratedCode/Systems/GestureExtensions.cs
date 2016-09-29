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
    
    
    #region 
static
    public class GestureExtensions {
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<HandComponent> HandComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<HandComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<IndexFingerComponent> IndexFingerComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<IndexFingerComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<ExcerciseManagerComponent> ExcerciseManagerComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<ExcerciseManagerComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<MainButton> MainButtonManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MainButton>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<Easy> EasyManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Easy>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<Button> ButtonManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Button>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<Hard> HardManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Hard>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<Difficulty> DifficultyManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Difficulty>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<Menu> MenuManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Menu>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<Medium> MediumManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Medium>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<MediumButton> MediumButtonManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MediumButton>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<MenuButton> MenuButtonManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuButton>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<EasyButton> EasyButtonManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<EasyButton>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<HardButton> HardButtonManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<HardButton>();
        }
        #endregion
        
        #region 
static
        public List<HandComponent> HandComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<HandComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<IndexFingerComponent> IndexFingerComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<IndexFingerComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<ExcerciseManagerComponent> ExcerciseManagerComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<ExcerciseManagerComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<MainButton> MainButtonComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MainButton>().Components;
        }
        #endregion
        
        #region 
static
        public List<Easy> EasyComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Easy>().Components;
        }
        #endregion
        
        #region 
static
        public List<Button> ButtonComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Button>().Components;
        }
        #endregion
        
        #region 
static
        public List<Hard> HardComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Hard>().Components;
        }
        #endregion
        
        #region 
static
        public List<Difficulty> DifficultyComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Difficulty>().Components;
        }
        #endregion
        
        #region 
static
        public List<Menu> MenuComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Menu>().Components;
        }
        #endregion
        
        #region 
static
        public List<Medium> MediumComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Medium>().Components;
        }
        #endregion
        
        #region 
static
        public List<MediumButton> MediumButtonComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MediumButton>().Components;
        }
        #endregion
        
        #region 
static
        public List<MenuButton> MenuButtonComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuButton>().Components;
        }
        #endregion
        
        #region 
static
        public List<EasyButton> EasyButtonComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<EasyButton>().Components;
        }
        #endregion
        
        #region 
static
        public List<HardButton> HardButtonComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<HardButton>().Components;
        }
        #endregion
    }
    #endregion
}