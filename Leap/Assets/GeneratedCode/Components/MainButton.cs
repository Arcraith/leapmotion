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
    using LeapDB;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(30)]
    [uFrame.Attributes.uFrameIdentifier("7b5cf1b2-27ad-4d8d-8d77-6e9bb43aa305")]
    public partial class MainButton : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Button _easybutton;
        
        [UnityEngine.SerializeField()]
        private Button _mediumbutton;
        
        [UnityEngine.SerializeField()]
        private Button _hardbutton;
        
        [UnityEngine.SerializeField()]
        private Boolean _handStretched;
        
        private Subject<PropertyChangedEvent<Button>> _easybuttonObservable;
        
        private PropertyChangedEvent<Button> _easybuttonEvent;
        
        private Subject<PropertyChangedEvent<Button>> _mediumbuttonObservable;
        
        private PropertyChangedEvent<Button> _mediumbuttonEvent;
        
        private Subject<PropertyChangedEvent<Button>> _hardbuttonObservable;
        
        private PropertyChangedEvent<Button> _hardbuttonEvent;
        
        private Subject<PropertyChangedEvent<Boolean>> _handStretchedObservable;
        
        private PropertyChangedEvent<Boolean> _handStretchedEvent;
        
        public override int ComponentId {
            get {
                return 30;
            }
        }
        
        public IObservable<PropertyChangedEvent<Button>> easybuttonObservable {
            get {
                return _easybuttonObservable ?? (_easybuttonObservable = new Subject<PropertyChangedEvent<Button>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Button>> mediumbuttonObservable {
            get {
                return _mediumbuttonObservable ?? (_mediumbuttonObservable = new Subject<PropertyChangedEvent<Button>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Button>> hardbuttonObservable {
            get {
                return _hardbuttonObservable ?? (_hardbuttonObservable = new Subject<PropertyChangedEvent<Button>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Boolean>> handStretchedObservable {
            get {
                return _handStretchedObservable ?? (_handStretchedObservable = new Subject<PropertyChangedEvent<Boolean>>());
            }
        }
        
        public Button easybutton {
            get {
                return _easybutton;
            }
            set {
                Seteasybutton(value);
            }
        }
        
        public Button mediumbutton {
            get {
                return _mediumbutton;
            }
            set {
                Setmediumbutton(value);
            }
        }
        
        public Button hardbutton {
            get {
                return _hardbutton;
            }
            set {
                Sethardbutton(value);
            }
        }
        
        public Boolean handStretched {
            get {
                return _handStretched;
            }
            set {
                SethandStretched(value);
            }
        }
        
        public virtual void Seteasybutton(Button value) {
            SetProperty(ref _easybutton, value, ref _easybuttonEvent, _easybuttonObservable);
        }
        
        public virtual void Setmediumbutton(Button value) {
            SetProperty(ref _mediumbutton, value, ref _mediumbuttonEvent, _mediumbuttonObservable);
        }
        
        public virtual void Sethardbutton(Button value) {
            SetProperty(ref _hardbutton, value, ref _hardbuttonEvent, _hardbuttonObservable);
        }
        
        public virtual void SethandStretched(Boolean value) {
            SetProperty(ref _handStretched, value, ref _handStretchedEvent, _handStretchedObservable);
        }
    }
}
