﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Movement : MonoBehaviour {

    public LayerMask groundLayer;
    public NavMeshAgent playerAgent;
    bool selected;

    private void Awake()
    {
        selected = false;
    }

	// Update is called once per frame
	void Update ()
    {
        if(selected)
        {
            if (Input.GetMouseButtonDown(1))
            {
                playerAgent.SetDestination(GetPointUnderCursor());
            }
        }
	}

    private Vector3 GetPointUnderCursor()
    {
        RaycastHit hitPosition;

        Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitPosition, Mathf.Infinity, groundLayer);

        return hitPosition.point;
    }

    public void Selected(bool pSelected)
    {
        selected = pSelected;
    }
}