using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildScript
{
    [MenuItem("MyMenu/Build")]
    static void PerformBuild()
    {
        string[] defaultScene = {
            "Assets/Samples/Universal RP/13.1.8/URP Package Samples/Decals/ProxyLighting/ProxyLighting.unity",
            };

        BuildPipeline.BuildPlayer(defaultScene, "MyGame.apk",
            BuildTarget.Android, BuildOptions.None);
    }

}