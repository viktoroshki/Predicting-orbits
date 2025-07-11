using UnityEngine;

public struct body
{
    public Vector3 position;
    public Vector3 velocity;
    public float radius;
    public float mass;

    public body(Vector3 position, Vector3 velocity, float radius, float mass)
    {
        this.position = position;
        this.velocity = velocity;
        this.radius = radius;
        this.mass = mass;
    }
}

public class GlobalVariables
{
    public static body[] bodies = new body[3]; // Array of bodies in the simulation
    public static Transform[] transformArray; // Where all the visuals are in the scene

    public static float gravitationalConstant = 1.0f;

    // Spawn conditions for the bodies
    public static Vector3 body1Velocity = new Vector3(0, 0, 0);
    public static Vector3 body1Position = new Vector3(0, 0, 0);
    public static float body1Radius = 1f;

    public static Vector3 body2Velocity = new Vector3(0, 0, 0);
    public static Vector3 body2Position = new Vector3(0, 0, 0);
    public static float body2Radius = 1f;

    public static Vector3 body3Velocity = new Vector3(0, 0, 0);
    public static Vector3 body3Position = new Vector3(0, 0, 0);
    public static float body3Radius = 1f;
}
