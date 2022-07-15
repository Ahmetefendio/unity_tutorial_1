using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -10);
    Transform pt;
    // Start is called before the first frame update
    void Start()
    {
       pt = GameObject.Find("Vehicle").GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = player.transform.position; // this is the other way to get ref.
        transform.position = pt.position + offset;
    }
}
