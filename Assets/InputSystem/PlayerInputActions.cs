//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/InputSystem/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""MechLegs"",
            ""id"": ""610ed09b-4433-40dd-980a-d4086614d0ad"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f01ab301-fbc2-43eb-8a84-03545af6bae2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a83fd20a-cdd5-48d7-9f52-4df549d88e13"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cf07d6b0-af6d-45c5-95f8-07cc9172478c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4f3e4959-0d8e-4205-84d9-a1d66214e709"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""52ddcbbc-216b-4ea3-b17b-d763465d8a63"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7b2e0e9b-319b-4a4a-bc7e-23f323b0954e"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""MechTorso"",
            ""id"": ""322c23eb-3944-467d-a71e-aa53e290bb8b"",
            ""actions"": [
                {
                    ""name"": ""LookAround"",
                    ""type"": ""Value"",
                    ""id"": ""e53a7c11-dc86-487f-b483-cf2fbef5098c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ShootLeft"",
                    ""type"": ""Button"",
                    ""id"": ""b554bb6d-722e-46ed-8a9b-032db056cce5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootRight"",
                    ""type"": ""Button"",
                    ""id"": ""02acc39c-5025-4d8c-9eac-536ef5c11c38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ReloadLeft"",
                    ""type"": ""Button"",
                    ""id"": ""2ce9b6f5-b8d8-4096-9c14-13981b57a581"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ReloadRight"",
                    ""type"": ""Button"",
                    ""id"": ""1846ebd8-71a5-4ede-9998-7112c0f5ec79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3856cc95-f27f-473f-bd9d-5dbcc9ae512e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookAround"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""29bf1af1-13d1-409c-b57b-5f7a4e1ab1b7"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookAround"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bdb4fb4b-89fd-4179-b74a-bb39e6e4f000"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookAround"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b9812008-8c38-401e-a3d5-3df74ad00d88"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookAround"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""64e1a9ad-db5f-401e-a2b2-38980f9ae900"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookAround"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6e5059db-55a6-4d31-b048-6ba9ccb43355"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11ead1d9-0031-4b67-86e1-a2300be6b9ba"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be95986c-d61d-4bcf-8d3e-950a24c6d8df"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReloadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1cd8324-e153-4c60-8888-a21714558d43"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReloadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MechLegs
        m_MechLegs = asset.FindActionMap("MechLegs", throwIfNotFound: true);
        m_MechLegs_Movement = m_MechLegs.FindAction("Movement", throwIfNotFound: true);
        // MechTorso
        m_MechTorso = asset.FindActionMap("MechTorso", throwIfNotFound: true);
        m_MechTorso_LookAround = m_MechTorso.FindAction("LookAround", throwIfNotFound: true);
        m_MechTorso_ShootLeft = m_MechTorso.FindAction("ShootLeft", throwIfNotFound: true);
        m_MechTorso_ShootRight = m_MechTorso.FindAction("ShootRight", throwIfNotFound: true);
        m_MechTorso_ReloadLeft = m_MechTorso.FindAction("ReloadLeft", throwIfNotFound: true);
        m_MechTorso_ReloadRight = m_MechTorso.FindAction("ReloadRight", throwIfNotFound: true);
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

    // MechLegs
    private readonly InputActionMap m_MechLegs;
    private IMechLegsActions m_MechLegsActionsCallbackInterface;
    private readonly InputAction m_MechLegs_Movement;
    public struct MechLegsActions
    {
        private @PlayerInputActions m_Wrapper;
        public MechLegsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_MechLegs_Movement;
        public InputActionMap Get() { return m_Wrapper.m_MechLegs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MechLegsActions set) { return set.Get(); }
        public void SetCallbacks(IMechLegsActions instance)
        {
            if (m_Wrapper.m_MechLegsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MechLegsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MechLegsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MechLegsActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_MechLegsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public MechLegsActions @MechLegs => new MechLegsActions(this);

    // MechTorso
    private readonly InputActionMap m_MechTorso;
    private IMechTorsoActions m_MechTorsoActionsCallbackInterface;
    private readonly InputAction m_MechTorso_LookAround;
    private readonly InputAction m_MechTorso_ShootLeft;
    private readonly InputAction m_MechTorso_ShootRight;
    private readonly InputAction m_MechTorso_ReloadLeft;
    private readonly InputAction m_MechTorso_ReloadRight;
    public struct MechTorsoActions
    {
        private @PlayerInputActions m_Wrapper;
        public MechTorsoActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LookAround => m_Wrapper.m_MechTorso_LookAround;
        public InputAction @ShootLeft => m_Wrapper.m_MechTorso_ShootLeft;
        public InputAction @ShootRight => m_Wrapper.m_MechTorso_ShootRight;
        public InputAction @ReloadLeft => m_Wrapper.m_MechTorso_ReloadLeft;
        public InputAction @ReloadRight => m_Wrapper.m_MechTorso_ReloadRight;
        public InputActionMap Get() { return m_Wrapper.m_MechTorso; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MechTorsoActions set) { return set.Get(); }
        public void SetCallbacks(IMechTorsoActions instance)
        {
            if (m_Wrapper.m_MechTorsoActionsCallbackInterface != null)
            {
                @LookAround.started -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnLookAround;
                @LookAround.performed -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnLookAround;
                @LookAround.canceled -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnLookAround;
                @ShootLeft.started -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnShootLeft;
                @ShootLeft.performed -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnShootLeft;
                @ShootLeft.canceled -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnShootLeft;
                @ShootRight.started -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnShootRight;
                @ShootRight.performed -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnShootRight;
                @ShootRight.canceled -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnShootRight;
                @ReloadLeft.started -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnReloadLeft;
                @ReloadLeft.performed -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnReloadLeft;
                @ReloadLeft.canceled -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnReloadLeft;
                @ReloadRight.started -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnReloadRight;
                @ReloadRight.performed -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnReloadRight;
                @ReloadRight.canceled -= m_Wrapper.m_MechTorsoActionsCallbackInterface.OnReloadRight;
            }
            m_Wrapper.m_MechTorsoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LookAround.started += instance.OnLookAround;
                @LookAround.performed += instance.OnLookAround;
                @LookAround.canceled += instance.OnLookAround;
                @ShootLeft.started += instance.OnShootLeft;
                @ShootLeft.performed += instance.OnShootLeft;
                @ShootLeft.canceled += instance.OnShootLeft;
                @ShootRight.started += instance.OnShootRight;
                @ShootRight.performed += instance.OnShootRight;
                @ShootRight.canceled += instance.OnShootRight;
                @ReloadLeft.started += instance.OnReloadLeft;
                @ReloadLeft.performed += instance.OnReloadLeft;
                @ReloadLeft.canceled += instance.OnReloadLeft;
                @ReloadRight.started += instance.OnReloadRight;
                @ReloadRight.performed += instance.OnReloadRight;
                @ReloadRight.canceled += instance.OnReloadRight;
            }
        }
    }
    public MechTorsoActions @MechTorso => new MechTorsoActions(this);
    public interface IMechLegsActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IMechTorsoActions
    {
        void OnLookAround(InputAction.CallbackContext context);
        void OnShootLeft(InputAction.CallbackContext context);
        void OnShootRight(InputAction.CallbackContext context);
        void OnReloadLeft(InputAction.CallbackContext context);
        void OnReloadRight(InputAction.CallbackContext context);
    }
}
