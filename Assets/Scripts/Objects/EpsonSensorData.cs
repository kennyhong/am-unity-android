using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EpsonSensorData
{
    public Acceleration Acceleration;
    public LinearAcceleration LinearAcceleration;
    public RotationVector RotationVector;
    public Gyroscope Gyroscope;
}

[System.Serializable]
public class Acceleration
{
    public float x;
    public float y;
    public float z;
}

[System.Serializable]
public class RotationVector
{
    public float x;
    public float y;
    public float z;
}

[System.Serializable]
public class LinearAcceleration
{
    public float x;
    public float y;
    public float z;
}

[System.Serializable]
public class Gyroscope
{
    public float x;
    public float y;
    public float z;
}