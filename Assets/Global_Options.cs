using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Global_Options
{
    // in these scripts we have functions for each change of options. for now these may seem useless but in the future we might need to call more things when these are changed
    // such as calling off to every spawned triangle to change their colour, instead of them fetching it from this script every frame (which is quite slow)

    public static class Spawner
    {
        public static float Amount = 200;
        public static void ChangeAmount(float amount)
        {
            Amount = amount;
        }
    }
    public static class Triangle
    {
        public static float Speed = 2;
        public static float MinScale = 1;
        public static float MaxScale = 9;
                
        public static float SpeedMultiplier = 100; 
        // how much the speed is multiplied by based on triangle size
        // since smaller triangles move faster, we get the MaxScale and remove the current Scale of the triangle. so if the triangle is small we get out a number
        // lets say MaxScale is 9 and MinScale is 1, we have a triangle of Scale 4.
        // the extra speed would be 5.
        // we then multiply that by speed multiplier, which is lets say 3. 15.
        // we then multiply Speed (local) by that number we now have
        // this way with this number people can make smaller triangles go faster or slower depending on what they want, and with minus numbers even possibly the opposite.

        public class Colour
        {
            public static float ColourVarianceUp = 0.1f;
            public static float ColourVarianceDown = -0.1f;
            public static Color TriangleColour = new Color(1, 1, 1, 1);

            public static void ChangeTriangleColour(Color newColor)
            {
                TriangleColour = newColor;
            }

            public static void ChangeColourVariance(float up, float down)
            {
                ColourVarianceUp = up;
                ColourVarianceDown = down;
            }
        }

        public static void ChangeSpeed(float speed)
        {
            Speed = speed;
        }
        public static void ChangeMinScale(float minScale)
        {
            MinScale = minScale;
        }
        public static void ChangeMaxScale(float maxScale)
        {
            MaxScale = maxScale;
        }
        public static void ChangeSpeedMultiplier(float speedMultiplier)
        {
            SpeedMultiplier = speedMultiplier;
        }
    }
}

public static class Global
{
    public static Vector2 topRight;
}