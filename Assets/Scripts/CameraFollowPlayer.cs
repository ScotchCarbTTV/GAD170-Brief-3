using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    //reference to the object we want the camera to follow
    [SerializeField] GameObject player;

    //speed which the camera will follow the player at
    [SerializeField] float speed;

    //float for how 'zoomed in' the camera is
    [SerializeField] float distance;

    private Vector3 targetPos;

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector3(player.transform.position.x, distance, player.transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);
        
    }
}
