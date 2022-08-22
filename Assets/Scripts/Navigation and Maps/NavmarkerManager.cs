using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavmarkerManager : MonoBehaviour
{
    [SerializeField] private List<Transform> navMarkers = new List<Transform>();

    public Transform GetRandomNavMarker()
    {
        int ran = Random.Range(0, navMarkers.Count);
        return navMarkers[ran];
    }
    
}
