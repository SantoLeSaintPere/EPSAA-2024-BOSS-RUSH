//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/INPUTS/GameInputControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GameInputControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputControls"",
    ""maps"": [
        {
            ""name"": ""PLAYER"",
            ""id"": ""435e74c9-d49b-46d0-8fd2-1641d586cf32"",
            ""actions"": [
                {
                    ""name"": ""MOVE"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b2c543fb-f881-45ab-a63d-f86cc343987f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ROTATEY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f057eb83-db4d-4d23-a0e9-69986b698539"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AIM"",
                    ""type"": ""Button"",
                    ""id"": ""7966c35d-624e-4a97-966a-a27e08fe6a3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SHOOT"",
                    ""type"": ""Button"",
                    ""id"": ""8aa4c002-e12f-4842-9383-775e3b1b6729"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ATTACK"",
                    ""type"": ""Button"",
                    ""id"": ""a7378be7-ab54-45f2-96b3-91aa37355d6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DASH"",
                    ""type"": ""Button"",
                    ""id"": ""d067b6fe-83af-41bd-8ae1-b05142faaa7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""07fb7ceb-b9b9-471a-b7b3-13317f329990"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8b3fb371-bb45-4acf-87e7-c91a1cb89155"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a4f08d76-a78c-4420-8fcf-7d9628bf14f8"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c37164eb-f20a-4663-88c7-6694b65b82cb"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6611505e-337e-42d4-beb7-2df5ae072baa"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a602b62c-9bd9-4243-96b7-d48a8f94f237"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""31bb2c8e-f831-4d7d-ab98-62d343a966ad"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1f1d3b0f-64a1-4575-930c-4d6de20000ce"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dbf39cdb-7402-45fc-9e67-308784d1f8a7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f0070716-878f-4319-a22d-2708715cfb34"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7ddcd543-4650-4018-8e9a-826b42d887df"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b6dcae65-4ab1-4a7c-917b-54747b46b5b7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d8348201-2fc5-425c-a1eb-ea638fae2cb7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cfd933e2-5084-441d-92a4-8209392c559a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ae93a295-a64f-4bc4-93a5-9b3e1993c13a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0b6fb4c6-c38e-4bd8-aec1-6aed448a1f9e"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MOUSE&KEYBOARD"",
                    ""action"": ""ROTATEY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f8b0204-c2a2-4171-822c-27cbdcffcc20"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ROTATEY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e71185a-ad39-4281-b8ad-765966156243"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MOUSE&KEYBOARD"",
                    ""action"": ""AIM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f808dcc-1781-4fbf-b788-b4d9edda6af5"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AIM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd4a1251-5e60-410c-bb00-4a0faef108a6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MOUSE&KEYBOARD"",
                    ""action"": ""SHOOT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47f6e883-e372-425e-9d96-43f587cd1f80"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SHOOT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fee091c-75bf-4442-bf8d-ee310a8481dd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MOUSE&KEYBOARD"",
                    ""action"": ""ATTACK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5db001ce-6d94-4da5-89b4-b00feb89a4c7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ATTACK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ffb2520-edc5-4963-b8aa-7fcc70f8f416"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MOUSE&KEYBOARD"",
                    ""action"": ""DASH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9824db08-b9f8-4c95-a77b-68fd5804b65a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DASH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MENU"",
            ""id"": ""daae5335-3aed-438b-b82b-ea34803a8633"",
            ""actions"": [
                {
                    ""name"": ""PASS"",
                    ""type"": ""Button"",
                    ""id"": ""8bf3a1fd-5bcc-4ed6-86b4-8fc30867f5d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""127f4aae-56a8-4754-a14b-f559605a2eef"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PASS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57958dd7-f40c-471c-b8d9-dbe16dd6a3cb"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PASS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GAMEMANAGER"",
            ""id"": ""4a00d7be-8ad4-4e84-960d-2993859b7058"",
            ""actions"": [
                {
                    ""name"": ""QUIT"",
                    ""type"": ""Button"",
                    ""id"": ""bdc6cbd9-df25-4b93-a613-4248536f255f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RELOAD"",
                    ""type"": ""Button"",
                    ""id"": ""7d23e693-9646-47d8-9a00-6e5b0cc45b6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PAUSE"",
                    ""type"": ""Button"",
                    ""id"": ""e015a278-26f7-4c6e-8880-c5794bfb7795"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ab0240e2-5393-4ec7-b425-32c035006181"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KEYBOARD&MOUSE"",
                    ""action"": ""QUIT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08d4dfc5-97bc-4757-8503-fa9bde6e3ec2"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RELOAD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""788df65b-95db-4033-8c6f-296665689ab2"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RELOAD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7961360-a641-4954-a272-26ce9ae62f5f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PAUSE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MOUSE&KEYBOARD"",
            ""bindingGroup"": ""MOUSE&KEYBOARD"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PLAYER
        m_PLAYER = asset.FindActionMap("PLAYER", throwIfNotFound: true);
        m_PLAYER_MOVE = m_PLAYER.FindAction("MOVE", throwIfNotFound: true);
        m_PLAYER_ROTATEY = m_PLAYER.FindAction("ROTATEY", throwIfNotFound: true);
        m_PLAYER_AIM = m_PLAYER.FindAction("AIM", throwIfNotFound: true);
        m_PLAYER_SHOOT = m_PLAYER.FindAction("SHOOT", throwIfNotFound: true);
        m_PLAYER_ATTACK = m_PLAYER.FindAction("ATTACK", throwIfNotFound: true);
        m_PLAYER_DASH = m_PLAYER.FindAction("DASH", throwIfNotFound: true);
        // MENU
        m_MENU = asset.FindActionMap("MENU", throwIfNotFound: true);
        m_MENU_PASS = m_MENU.FindAction("PASS", throwIfNotFound: true);
        // GAMEMANAGER
        m_GAMEMANAGER = asset.FindActionMap("GAMEMANAGER", throwIfNotFound: true);
        m_GAMEMANAGER_QUIT = m_GAMEMANAGER.FindAction("QUIT", throwIfNotFound: true);
        m_GAMEMANAGER_RELOAD = m_GAMEMANAGER.FindAction("RELOAD", throwIfNotFound: true);
        m_GAMEMANAGER_PAUSE = m_GAMEMANAGER.FindAction("PAUSE", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PLAYER
    private readonly InputActionMap m_PLAYER;
    private List<IPLAYERActions> m_PLAYERActionsCallbackInterfaces = new List<IPLAYERActions>();
    private readonly InputAction m_PLAYER_MOVE;
    private readonly InputAction m_PLAYER_ROTATEY;
    private readonly InputAction m_PLAYER_AIM;
    private readonly InputAction m_PLAYER_SHOOT;
    private readonly InputAction m_PLAYER_ATTACK;
    private readonly InputAction m_PLAYER_DASH;
    public struct PLAYERActions
    {
        private @GameInputControls m_Wrapper;
        public PLAYERActions(@GameInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MOVE => m_Wrapper.m_PLAYER_MOVE;
        public InputAction @ROTATEY => m_Wrapper.m_PLAYER_ROTATEY;
        public InputAction @AIM => m_Wrapper.m_PLAYER_AIM;
        public InputAction @SHOOT => m_Wrapper.m_PLAYER_SHOOT;
        public InputAction @ATTACK => m_Wrapper.m_PLAYER_ATTACK;
        public InputAction @DASH => m_Wrapper.m_PLAYER_DASH;
        public InputActionMap Get() { return m_Wrapper.m_PLAYER; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PLAYERActions set) { return set.Get(); }
        public void AddCallbacks(IPLAYERActions instance)
        {
            if (instance == null || m_Wrapper.m_PLAYERActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PLAYERActionsCallbackInterfaces.Add(instance);
            @MOVE.started += instance.OnMOVE;
            @MOVE.performed += instance.OnMOVE;
            @MOVE.canceled += instance.OnMOVE;
            @ROTATEY.started += instance.OnROTATEY;
            @ROTATEY.performed += instance.OnROTATEY;
            @ROTATEY.canceled += instance.OnROTATEY;
            @AIM.started += instance.OnAIM;
            @AIM.performed += instance.OnAIM;
            @AIM.canceled += instance.OnAIM;
            @SHOOT.started += instance.OnSHOOT;
            @SHOOT.performed += instance.OnSHOOT;
            @SHOOT.canceled += instance.OnSHOOT;
            @ATTACK.started += instance.OnATTACK;
            @ATTACK.performed += instance.OnATTACK;
            @ATTACK.canceled += instance.OnATTACK;
            @DASH.started += instance.OnDASH;
            @DASH.performed += instance.OnDASH;
            @DASH.canceled += instance.OnDASH;
        }

        private void UnregisterCallbacks(IPLAYERActions instance)
        {
            @MOVE.started -= instance.OnMOVE;
            @MOVE.performed -= instance.OnMOVE;
            @MOVE.canceled -= instance.OnMOVE;
            @ROTATEY.started -= instance.OnROTATEY;
            @ROTATEY.performed -= instance.OnROTATEY;
            @ROTATEY.canceled -= instance.OnROTATEY;
            @AIM.started -= instance.OnAIM;
            @AIM.performed -= instance.OnAIM;
            @AIM.canceled -= instance.OnAIM;
            @SHOOT.started -= instance.OnSHOOT;
            @SHOOT.performed -= instance.OnSHOOT;
            @SHOOT.canceled -= instance.OnSHOOT;
            @ATTACK.started -= instance.OnATTACK;
            @ATTACK.performed -= instance.OnATTACK;
            @ATTACK.canceled -= instance.OnATTACK;
            @DASH.started -= instance.OnDASH;
            @DASH.performed -= instance.OnDASH;
            @DASH.canceled -= instance.OnDASH;
        }

        public void RemoveCallbacks(IPLAYERActions instance)
        {
            if (m_Wrapper.m_PLAYERActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPLAYERActions instance)
        {
            foreach (var item in m_Wrapper.m_PLAYERActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PLAYERActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PLAYERActions @PLAYER => new PLAYERActions(this);

    // MENU
    private readonly InputActionMap m_MENU;
    private List<IMENUActions> m_MENUActionsCallbackInterfaces = new List<IMENUActions>();
    private readonly InputAction m_MENU_PASS;
    public struct MENUActions
    {
        private @GameInputControls m_Wrapper;
        public MENUActions(@GameInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PASS => m_Wrapper.m_MENU_PASS;
        public InputActionMap Get() { return m_Wrapper.m_MENU; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MENUActions set) { return set.Get(); }
        public void AddCallbacks(IMENUActions instance)
        {
            if (instance == null || m_Wrapper.m_MENUActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MENUActionsCallbackInterfaces.Add(instance);
            @PASS.started += instance.OnPASS;
            @PASS.performed += instance.OnPASS;
            @PASS.canceled += instance.OnPASS;
        }

        private void UnregisterCallbacks(IMENUActions instance)
        {
            @PASS.started -= instance.OnPASS;
            @PASS.performed -= instance.OnPASS;
            @PASS.canceled -= instance.OnPASS;
        }

        public void RemoveCallbacks(IMENUActions instance)
        {
            if (m_Wrapper.m_MENUActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMENUActions instance)
        {
            foreach (var item in m_Wrapper.m_MENUActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MENUActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MENUActions @MENU => new MENUActions(this);

    // GAMEMANAGER
    private readonly InputActionMap m_GAMEMANAGER;
    private List<IGAMEMANAGERActions> m_GAMEMANAGERActionsCallbackInterfaces = new List<IGAMEMANAGERActions>();
    private readonly InputAction m_GAMEMANAGER_QUIT;
    private readonly InputAction m_GAMEMANAGER_RELOAD;
    private readonly InputAction m_GAMEMANAGER_PAUSE;
    public struct GAMEMANAGERActions
    {
        private @GameInputControls m_Wrapper;
        public GAMEMANAGERActions(@GameInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @QUIT => m_Wrapper.m_GAMEMANAGER_QUIT;
        public InputAction @RELOAD => m_Wrapper.m_GAMEMANAGER_RELOAD;
        public InputAction @PAUSE => m_Wrapper.m_GAMEMANAGER_PAUSE;
        public InputActionMap Get() { return m_Wrapper.m_GAMEMANAGER; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GAMEMANAGERActions set) { return set.Get(); }
        public void AddCallbacks(IGAMEMANAGERActions instance)
        {
            if (instance == null || m_Wrapper.m_GAMEMANAGERActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GAMEMANAGERActionsCallbackInterfaces.Add(instance);
            @QUIT.started += instance.OnQUIT;
            @QUIT.performed += instance.OnQUIT;
            @QUIT.canceled += instance.OnQUIT;
            @RELOAD.started += instance.OnRELOAD;
            @RELOAD.performed += instance.OnRELOAD;
            @RELOAD.canceled += instance.OnRELOAD;
            @PAUSE.started += instance.OnPAUSE;
            @PAUSE.performed += instance.OnPAUSE;
            @PAUSE.canceled += instance.OnPAUSE;
        }

        private void UnregisterCallbacks(IGAMEMANAGERActions instance)
        {
            @QUIT.started -= instance.OnQUIT;
            @QUIT.performed -= instance.OnQUIT;
            @QUIT.canceled -= instance.OnQUIT;
            @RELOAD.started -= instance.OnRELOAD;
            @RELOAD.performed -= instance.OnRELOAD;
            @RELOAD.canceled -= instance.OnRELOAD;
            @PAUSE.started -= instance.OnPAUSE;
            @PAUSE.performed -= instance.OnPAUSE;
            @PAUSE.canceled -= instance.OnPAUSE;
        }

        public void RemoveCallbacks(IGAMEMANAGERActions instance)
        {
            if (m_Wrapper.m_GAMEMANAGERActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGAMEMANAGERActions instance)
        {
            foreach (var item in m_Wrapper.m_GAMEMANAGERActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GAMEMANAGERActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GAMEMANAGERActions @GAMEMANAGER => new GAMEMANAGERActions(this);
    private int m_MOUSEKEYBOARDSchemeIndex = -1;
    public InputControlScheme MOUSEKEYBOARDScheme
    {
        get
        {
            if (m_MOUSEKEYBOARDSchemeIndex == -1) m_MOUSEKEYBOARDSchemeIndex = asset.FindControlSchemeIndex("MOUSE&KEYBOARD");
            return asset.controlSchemes[m_MOUSEKEYBOARDSchemeIndex];
        }
    }
    public interface IPLAYERActions
    {
        void OnMOVE(InputAction.CallbackContext context);
        void OnROTATEY(InputAction.CallbackContext context);
        void OnAIM(InputAction.CallbackContext context);
        void OnSHOOT(InputAction.CallbackContext context);
        void OnATTACK(InputAction.CallbackContext context);
        void OnDASH(InputAction.CallbackContext context);
    }
    public interface IMENUActions
    {
        void OnPASS(InputAction.CallbackContext context);
    }
    public interface IGAMEMANAGERActions
    {
        void OnQUIT(InputAction.CallbackContext context);
        void OnRELOAD(InputAction.CallbackContext context);
        void OnPAUSE(InputAction.CallbackContext context);
    }
}
