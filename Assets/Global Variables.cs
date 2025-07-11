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

    public static float gravitationalConstant = 1.0f;
    
}