using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollerPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 Offset = new Vector3(0,4,-15);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position  + Offset;
            }
}
