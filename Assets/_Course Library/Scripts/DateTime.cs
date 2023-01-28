using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTime : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Start()
    {

    }

    void Update()
    {
        System.DateTime time = System.DateTime.Now;

        float hourAngle = (time.Hour + time.Minute / 60f) * 360 / 12;
        float minuteAngle = (time.Minute + time.Second / 60f) * 360 / 60;
        float secondAngle = time.Second * 360 / 60;

        hourHand.localRotation = Quaternion.Euler(hourAngle, 0, 0);
        minuteHand.localRotation = Quaternion.Euler(minuteAngle, 0, 0);
        secondHand.localRotation = Quaternion.Euler(secondAngle, 0, 0);
    }
}