using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleReticle : MonoBehaviour
{
    private void Update()
    {
        // animation where reticle scales up and down from 0.8 to 1
        transform.localScale = Vector3.one * (0.8f + Mathf.PingPong(Time.time / 4, 0.2f));
    }
}
