﻿using UnityEngine;

public class RacingCar : Car
{
	// Use this for initialization
	protected override void Start ()
    {

	}
	
	// Update is called once per frame
	protected override void Update ()
    {
        StabilizeCar();	
	}

    private void StabilizeCar()
    {
        foreach (var axle in axleInfo)
        {

        }
    }
}
