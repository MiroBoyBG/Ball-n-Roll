﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToSkinsButtonScript : MonoBehaviour
{
   public  void BackToSkins()
    {
        ScoreText.objCount = 0;
        ScoreText.cordChecker = 0;
        VelocityCheckerScript.timeCounter = 0;
        VelocityCheckerScript.secTimeCounter = 0;
        ScoreText.timeController2 = false;
        PlayerCollision.exBool = true;
        PlayerCollision.collisionBool = false;
        MovingObstacleScript.moveForce = 0;
        PlaneCollisionScript.exCollCheck = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
