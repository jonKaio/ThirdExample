using System;
using System.Collections.Generic;
using System.Text;
using static Raylib_cs.Raylib;  // core methods (InitWindow, BeginDrawing())
using static Raylib_cs.Color;   // color (RAYWHITE, MAROON, etc.)
using static Raylib_cs.Raymath; // mathematics utilities and operations (Vector2Add, etc.)
using System.Numerics;          // mathematics types (Vector2, Vector3, etc.)
using Raylib_cs;

namespace raygamecsharp
{
    class Sprite
    {
        public Vector2 position = new Vector2();
        public float myRadius=10;
        public bool active = true;
        protected Color myColour=GREEN;
 

        public void Draw()
        {
            if (!active) return;

            DrawCircleV(position, myRadius, myColour);
        }

    }
}