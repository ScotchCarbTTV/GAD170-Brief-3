using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/*Script written by Ian 'Scotch' Bell
 * This script will be used for moving around the mech character on a 2d plane and animating the legs.
 * The character will need to be divided into the lower half (legs/hips) and upper half (torso/arms/head) for this to work. The upper half gets the MechTorso script.
 * The object this is attached to will need a rigidbody with gravity turned off and the rotation on the x/z axis locked.
 */

public class MechLegs : MonoBehaviour
{
    //float variable exposed to the editor for the move speed
    [SerializeField] private float moveSpeed;
    //float variable exposed to the editor for the turn speed
    [SerializeField] private float turnSpeed;

    private PlayerInputActions inputActions;

    //vector2 variable for input which will be translated to the d
    private Vector3 inputDir;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.Enable();
    }

    private void Update()
    {
        //check for input and assign the horizontal and vertical input values to the vector2 inputDir
        inputDir = new Vector3(inputActions.MechLegs.Movement.ReadValue<Vector2>().x, 0, inputActions.MechLegs.Movement.ReadValue<Vector2>().y);

        //use inputDir to rotate the characters legs in the direction it will move (modified by the turnspeed)
        if (inputDir != Vector3.zero)
        {
            transform.forward = Vector3.Slerp(transform.forward, inputDir, turnSpeed * Time.deltaTime);
        }

        //use inputDir * moveSpeed to move in the direction desired
        transform.position += inputDir * moveSpeed * Time.deltaTime;
    }


}
