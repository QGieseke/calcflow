﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using System;
using System.Reflection;

public abstract class PlayBackLogger : Nanome.Core.Behaviour
{
    public static void AddLoggers(Type t)
    {
        List<Component> objectsInScene = new List<Component>();
        Component[] comps = Resources.FindObjectsOfTypeAll(t) as Component[];
        foreach (Component co in comps)
        {
            if (co.gameObject.hideFlags == HideFlags.NotEditable || co.gameObject.hideFlags == HideFlags.HideAndDontSave)
                continue;
            if (co.gameObject.scene.name == null)
                continue;
            objectsInScene.Add(co);
        }
    }

    //public abstract void GetReenactors();
}