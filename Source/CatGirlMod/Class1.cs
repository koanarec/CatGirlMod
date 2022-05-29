using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using Verse;

namespace TestMod
{
    [StaticConstructorOnStartup]
    public static class MyMod
    {
        static MyMod() //our constructor
        {
            Log.Message("Hello World!TEST"); //Outputs "Hello World!" to the dev console.
            Log.Message("Hello World!TEST"); //Outputs "Hello World!" to the dev console.
            Log.Message("Hello World!TEST"); //Outputs "Hello World!" to the dev console.
            Log.Message("Hello World!TEST"); //Outputs "Hello World!" to the dev console.
            Log.Message("Hello World!TEST"); //Outputs "Hello World!" to the dev console.
            Log.Message("Hello World!TEST"); //Outputs "Hello World!" to the dev console.
        }
    }
}