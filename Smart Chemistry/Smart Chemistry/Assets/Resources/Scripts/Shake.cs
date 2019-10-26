using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public static bool shake; // check camera shake
    public static float shake_Time, shake_Intensity; // shake time and intensity

    void Update()
    {
        #region CAMERA SHAKE
        if (shake == true && shake_Time > 0)
        {
            Vector2 shakeMe = Random.insideUnitCircle * shake_Intensity;
            transform.position = new Vector3(transform.position.x + shakeMe.x, transform.position.y + shakeMe.y, transform.position.z);
            shake_Time -= Time.deltaTime;
        }
        #endregion
    }
}