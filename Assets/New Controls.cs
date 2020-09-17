// GENERATED AUTOMATICALLY FROM 'Assets/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controles : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controles()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""CubeMap"",
            ""id"": ""beac04ad-c77c-456d-adc7-382a0ee955ef"",
            ""actions"": [
                {
                    ""name"": ""Deplacement"",
                    ""type"": ""Value"",
                    ""id"": ""9192ad8b-77ca-468d-939e-5319f3ab2e28"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tirer"",
                    ""type"": ""Button"",
                    ""id"": ""3245adcd-4e94-4829-92a0-090f6c0d74ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""336c625c-b19f-462d-94c6-3e199a185790"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3df4677a-8634-48f5-9c17-84ebb79f798f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c9ac0780-b694-4fcd-8c0d-01096cc2f9e2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d6f6026f-d975-402a-9f94-78323b5e4e4f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0a50f479-1300-4974-bcb5-cf57ba48a93c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""66e5700e-4bfe-4be6-8708-5a6c6de7a61a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tirer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CubeMap
        m_CubeMap = asset.FindActionMap("CubeMap", throwIfNotFound: true);
        m_CubeMap_Deplacement = m_CubeMap.FindAction("Deplacement", throwIfNotFound: true);
        m_CubeMap_Tirer = m_CubeMap.FindAction("Tirer", throwIfNotFound: true);
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

    // CubeMap
    private readonly InputActionMap m_CubeMap;
    private ICubeMapActions m_CubeMapActionsCallbackInterface;
    private readonly InputAction m_CubeMap_Deplacement;
    private readonly InputAction m_CubeMap_Tirer;
    public struct CubeMapActions
    {
        private @Controles m_Wrapper;
        public CubeMapActions(@Controles wrapper) { m_Wrapper = wrapper; }
        public InputAction @Deplacement => m_Wrapper.m_CubeMap_Deplacement;
        public InputAction @Tirer => m_Wrapper.m_CubeMap_Tirer;
        public InputActionMap Get() { return m_Wrapper.m_CubeMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CubeMapActions set) { return set.Get(); }
        public void SetCallbacks(ICubeMapActions instance)
        {
            if (m_Wrapper.m_CubeMapActionsCallbackInterface != null)
            {
                @Deplacement.started -= m_Wrapper.m_CubeMapActionsCallbackInterface.OnDeplacement;
                @Deplacement.performed -= m_Wrapper.m_CubeMapActionsCallbackInterface.OnDeplacement;
                @Deplacement.canceled -= m_Wrapper.m_CubeMapActionsCallbackInterface.OnDeplacement;
                @Tirer.started -= m_Wrapper.m_CubeMapActionsCallbackInterface.OnTirer;
                @Tirer.performed -= m_Wrapper.m_CubeMapActionsCallbackInterface.OnTirer;
                @Tirer.canceled -= m_Wrapper.m_CubeMapActionsCallbackInterface.OnTirer;
            }
            m_Wrapper.m_CubeMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Deplacement.started += instance.OnDeplacement;
                @Deplacement.performed += instance.OnDeplacement;
                @Deplacement.canceled += instance.OnDeplacement;
                @Tirer.started += instance.OnTirer;
                @Tirer.performed += instance.OnTirer;
                @Tirer.canceled += instance.OnTirer;
            }
        }
    }
    public CubeMapActions @CubeMap => new CubeMapActions(this);
    public interface ICubeMapActions
    {
        void OnDeplacement(InputAction.CallbackContext context);
        void OnTirer(InputAction.CallbackContext context);
    }
}
