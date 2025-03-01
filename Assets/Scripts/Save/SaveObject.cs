﻿using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveObject
{
    [System.Serializable]
    public struct SerializeableVector3 
    {
        float x;
        float y;
        float z;
        public void SetData(Vector3 vector)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
        }
        public Vector3 GetData()
        {
            return new Vector3(x, y, z);
        }
    }

    // ---Player Data
    public float health;
    public float hunger;
    public float distanceSum;
    public string sceneName;
    public int steps;
    public int money;
    public bool starving;
    public SerializeableVector3 posInScene = new SerializeableVector3();
    public List<ItemObject> itemList = new List<ItemObject>();

    // ---Flags
    public List<string> keys = new List<string>();
    public List<bool> values = new List<bool>();
}