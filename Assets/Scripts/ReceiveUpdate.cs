using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ReceiveUpdate : MonoBehaviour
{
    private AndroidJavaClass jc;
    private EpsonSensorData sensorData;
    private float initialOrientationX;
    private float initialOrientationY;
    private float initialOrientationZ;

    //public TextMesh textbox;

    // Start is called before the first frame update
    void Start()
    {
       jc = new AndroidJavaClass("com.example.myreceiver.MyReceiver");
       jc.CallStatic("createInstance");
        string javaMessage = jc.GetStatic<string>("text");
        if (javaMessage != null)
       {
            sensorData = JsonUtility.FromJson<EpsonSensorData>(javaMessage);

            //textbox.text = "Gyroscope: x = " + sensorData.Gyroscope.x + ",y = " + sensorData.Gyroscope.y + ", z = " + sensorData.Gyroscope.z;
       }
    }

    // Update is called once per frame
    void Update()
    {
        string javaMessage = jc.GetStatic<string>("text");
        if (javaMessage != null)
        {
            sensorData = JsonUtility.FromJson<EpsonSensorData>(javaMessage);
            transform.Rotate(-sensorData.Gyroscope.x, -sensorData.Gyroscope.y, 0);
            //textbox.text = "Gyroscope: x = " + sensorData.Gyroscope.x + ",y = " + sensorData.Gyroscope.y + ", z = " + sensorData.Gyroscope.z;
        }
    }
}

