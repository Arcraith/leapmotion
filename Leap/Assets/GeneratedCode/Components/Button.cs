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
    using Invert.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(7)]
    [uFrame.Attributes.uFrameIdentifier("aecf7be6-39ef-423a-ba6b-a48ddb2c1a8d")]
    public partial class Button : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Boolean _selected;
        
        [UnityEngine.SerializeField()]
        private Boolean _active;
        
        private Subject<PropertyChangedEvent<Boolean>> _selectedObservable;
        
        private PropertyChangedEvent<Boolean> _selectedEvent;
        
        private Subject<PropertyChangedEvent<Boolean>> _activeObservable;
        
        private PropertyChangedEvent<Boolean> _activeEvent;
        
        public override int ComponentId {
            get {
                return 7;
            }
        }
        
        public IObservable<PropertyChangedEvent<Boolean>> selectedObservable {
            get {
                return _selectedObservable ?? (_selectedObservable = new Subject<PropertyChangedEvent<Boolean>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Boolean>> activeObservable {
            get {
                return _activeObservable ?? (_activeObservable = new Subject<PropertyChangedEvent<Boolean>>());
            }
        }
        
        public Boolean selected {
            get {
                return _selected;
            }
            set {
                Setselected(value);
            }
        }
        
        public Boolean active {
            get {
                return _active;
            }
            set {
                Setactive(value);
            }
        }
        
        public virtual void Setselected(Boolean value) {
            SetProperty(ref _selected, value, ref _selectedEvent, _selectedObservable);
        }
        
        public virtual void Setactive(Boolean value) {
            SetProperty(ref _active, value, ref _activeEvent, _activeObservable);
        }
    }
}
