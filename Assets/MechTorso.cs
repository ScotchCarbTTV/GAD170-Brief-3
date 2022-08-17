using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MechTorso : MonoBehaviour
{
    [SerializeField] Transform mechLegTransform;

    [SerializeField] float turnSpeed;

    private PlayerInputActions inputActions;

    private Vector3 lookDir;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(mechLegTransform.position.x, transform.position.y, (mechLegTransform.position.z - 0.3f));
        
        lookDir = new Vector3(inputActions.MechTorso.LookAround.ReadValue<Vector2>().x, 0, inputActions.MechTorso.LookAround.ReadValue<Vector2>().y);
        if (lookDir != Vector3.zero)
        {
            transform.forward = Vector3.Slerp(transform.forward, lookDir, turnSpeed * Time.deltaTime);
        }
    }
}
