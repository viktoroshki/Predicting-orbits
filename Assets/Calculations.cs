using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Calculations
{
    public static body[] processBodies(body[] bodies, float deltaTime)
    {
        for (int i = 0; i < bodies.Length; i++)
        {
            // Calculate the total velocity of the body due to the gravitational pull of all other bodies
            Vector3 totalVelocity = bodies[i].velocity; // Still has the inertia of its previous velocity
            for (int j = 0; j < bodies.Length; j++)
            {
                if (i == j) { continue; } // Stop the particle comparing to itself
                else
                {
                    Vector3 vDirDueToB = (bodies[j].position - bodies[i].position).normalized;
                    float distanceAB = (bodies[j].position - bodies[i].position).magnitude;
                    float forceDueToB = ((GlobalVariables.gravitationalConstant * bodies[i].mass * bodies[j].mass) / (distanceAB * distanceAB));

                    // F = ma  =>  a = F/m
                    float accelerationDueToB = forceDueToB / bodies[i].mass;

                    totalVelocity += vDirDueToB * accelerationDueToB * deltaTime;
                }
            }
            bodies[i].velocity = totalVelocity;

            // Update the position of the body based on its velocity
            bodies[i].position += bodies[i].velocity * deltaTime;
        }

        return bodies;
    }

}
