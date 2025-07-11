using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;

public class OrbitCalculation : EditorWindow
{
    uint simulationSteps = 1000;
    float timeStep = 0.1f; // Time step for each simulation step in seconds

    [MenuItem("Tools/Orbit Predicter")]
    static void Open() => GetWindow<OrbitCalculation>("Orbit Predicter");

    void OnEnable()
    {
        SceneView.duringSceneGui += OnSceneGUI;
        computeOrbits();
    }

    void OnDisable() => SceneView.duringSceneGui -= OnSceneGUI;
    void OnSceneGUI(SceneView sv) => LineDrawer.DrawAll();

    void computeOrbits()
    {
        body[] previousSimStep = GlobalVariables.bodies;
        body[] currentSimStep = new body[GlobalVariables.bodies.Length];

        for (uint step = 0; step < simulationSteps; step++)
        {
            currentSimStep = Calculations.processBodies(previousSimStep, timeStep);

            for (uint i = 0; i < currentSimStep.Length; i++)
            {
                LineDrawer.Add(previousSimStep[i].position, currentSimStep[i].position);
            }

            previousSimStep = currentSimStep;
        }
    }

    // Keeps the orbit paths on the scene view
    public static class LineDrawer
    {
        // Information about each line-segment to be drawn
        struct Segment
        {
            public Vector3 a, b;
            public Color color;
        }

        static readonly List<Segment> segments = new List<Segment>();

        // Adds a line segment to the list of segments to be drawn
        public static void Add(Vector3 from, Vector3 to, Color? color = null)
        {
            segments.Add(new Segment
            {
                a = from,
                b = to,
                color = color ?? Color.cyan
            });
            SceneView.RepaintAll();      // redraw immediately
        }

        // Clears scene view
        public static void Clear()
        {
            segments.Clear();
            SceneView.RepaintAll();
        }

        // Draw in all the lines
        internal static void DrawAll()
        {
            foreach (var s in segments)
            {
                Handles.color = s.color;
                Handles.DrawLine(s.a, s.b);
            }
        }
    }
}
