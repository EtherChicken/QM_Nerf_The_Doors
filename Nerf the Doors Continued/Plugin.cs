using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.CodeDom;
using System.Net.Mime;
using Unity;
// using System.Runtime.Serialization.Json;
// using SimpleJSON;

namespace Nerf_the_Doors_Continued
{
    public class Plugin
    {
        [Hook(ModHookType.BeforeBootstrap)]
        public static void Bootstrap(IModContext context)
        {
            Harmony harmony = new Harmony("Nerf_the_Doors_Continued");
            harmony.PatchAll();
            Debug.Log((object)"New Door Nerf loaded :) \n \n \n");
        }
    }
}

