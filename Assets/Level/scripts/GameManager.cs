﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager self;

    public TouchManager touchManager;
    public BallsManager ballsManager;

    private void Awake()
    {
        self = this;
    }
}
