using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibPhysic : MonoBehaviour
{
    //reference to the rigidbody
    [SerializeField] Rigidbody rBdody;

    private void Awake()
    {
        rBdody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 ranVect = new Vector3(GetRandomFloat(), GetRandomFloat(), GetRandomFloat());
        rBdody.velocity = ranVect * 5;        
    }
    

    private float GetRandomFloat()
    {
        float ran = Random.Range(-1, 1);
        return ran;
    }
}
