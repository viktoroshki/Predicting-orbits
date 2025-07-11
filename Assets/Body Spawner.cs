using Unity.VisualScripting;
using UnityEngine;

public class BodySpawner : MonoBehaviour
{
    public Transform body1Visual;
    public Transform body2Visual;
    public Transform body3Visual;

    void Start()
    {
        GlobalVariables.bodies[0] = new body(GlobalVariables.body1Position, GlobalVariables.body1Velocity, GlobalVariables.body1Radius, 1f);
        GlobalVariables.bodies[1] = new body(GlobalVariables.body2Position, GlobalVariables.body2Velocity, GlobalVariables.body2Radius, 1f);
        GlobalVariables.bodies[2] = new body(GlobalVariables.body3Position, GlobalVariables.body3Velocity, GlobalVariables.body3Radius, 1f);

        GlobalVariables.transformArray[0] = body1Visual;
        GlobalVariables.transformArray[1] = body2Visual;
        GlobalVariables.transformArray[2] = body3Visual;
    }
}
