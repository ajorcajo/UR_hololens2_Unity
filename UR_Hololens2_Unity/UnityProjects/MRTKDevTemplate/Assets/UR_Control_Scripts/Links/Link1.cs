using System;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Link1 : MonoBehaviour
{
    void FixedUpdate()
    {
        try
        {
            transform.localEulerAngles = new Vector3(0.0f, (-1.0f) * (float)(ur_data_processing.UR_Stream_Data.J_Orientation[0] * (180.0 / Math.PI)), 0.0f);
        }
        catch (Exception e)
        {
            Debug.Log("Exception:" + e);
        }
    }
    void OnApplicationQuit()
    {
        Destroy(this);
    }
}
