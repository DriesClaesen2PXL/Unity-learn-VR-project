using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    public Transform hoursTransform, minutesTransform, secondsTransform;
    const float hoursToDegrees = 30f, minutesToDegrees = 6f, secondsToDegrees = 6f;

    void Update()
    {
        System.DateTime time = System.DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(hoursToDegrees * time.Hour, 0, 0);
        minutesTransform.localRotation = Quaternion.Euler(minutesToDegrees * time.Minute, 0, 0);
        secondsTransform.localRotation = Quaternion.Euler(secondsToDegrees * time.Second, 0, 0);
    }
}
