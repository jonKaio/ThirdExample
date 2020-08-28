﻿using System;
using System.Collections.Generic;
using System.Text;
using static Raylib_cs.Raylib;  // core methods (InitWindow, BeginDrawing())
using static Raylib_cs.Color;   // color (RAYWHITE, MAROON, etc.)
using static Raylib_cs.Raymath; // mathematics utilities and operations (Vector2Add, etc.)
using System.Numerics;          // mathematics types (Vector2, Vector3, etc.)
using Raylib_cs;

namespace raygamecsharp
{
    class Player : Sprite
    {
        public Player()
        {
            myColour = BLUE;
        }

        public void Update()
        {
            position = GetMousePosition();
            
        }
    }
}
