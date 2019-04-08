﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(WayPoint))]
public class CubeEditor : MonoBehaviour
{

    WayPoint wayPoint;

    private void Awake()
    {
        wayPoint = GetComponent<WayPoint>();
    }

    private void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }

    private void SnapToGrid()
    {
        int gridSize = wayPoint.GetGridSize();
        transform.position = new Vector3(
            wayPoint.GetGridPos().x * gridSize,
            0f,
            wayPoint.GetGridPos().y * gridSize
            );
    }

    private void UpdateLabel()
    {
        int gridLimit = wayPoint.GetGridSize();
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        string labelText = wayPoint.GetGridPos().x + "," + wayPoint.GetGridPos().y;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
