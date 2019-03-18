﻿using UnityEngine;

public class waypoints : MonoBehaviour
{
    public static Transform[] point;

    void Awake()
    {
        point = new Transform[transform.childCount];
        for (int i = 0; i < point.Length; i++)
        {
            point[i] = transform.GetChild(i);
        }
    }
}