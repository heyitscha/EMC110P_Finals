using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteadyCamera : MonoBehaviour
{
    public GameObject Player;
    public float PlayerX;
    public float PlayerY;
    public float PlayerZ;

    void Update()
    {
        PlayerX = Player.transform.eulerAngles.x;
        PlayerY = Player.transform.eulerAngles.y;
        PlayerZ = Player.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(PlayerX - PlayerX, PlayerY = 0, PlayerZ - PlayerZ);

        //make it so the X and Z angles are reversed from the direction of the camera, making the camera angle steady at all times
        // Y angle is kept constant
    }
}
