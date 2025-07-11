using UnityEngine;

// This script is here so we can change the settings of the starting conditions of the boids from "the outside" (inspector)
public class BodySettings : MonoBehaviour
{
    public Vector3 body1Velocity;
    public Vector3 body1Position;
    public float body1Radius;

    public Vector3 body2Velocity;
    public Vector3 body2Position;
    public float body2Radius;

    public Vector3 body3Velocity;
    public Vector3 body3Position;
    public float body3Radius;

    void Awake()
    {
        GlobalVariables.body1Velocity = body1Velocity;
        GlobalVariables.body1Position = body1Position;
        GlobalVariables.body1Radius = body1Radius;

        GlobalVariables.body2Velocity = body2Velocity;
        GlobalVariables.body2Position = body2Position;
        GlobalVariables.body2Radius = body2Radius;

        GlobalVariables.body3Velocity = body3Velocity;
        GlobalVariables.body3Position = body3Position;
        GlobalVariables.body3Radius = body3Radius;
    }
}
