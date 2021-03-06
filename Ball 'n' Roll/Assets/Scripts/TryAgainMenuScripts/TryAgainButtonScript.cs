﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButtonScript : MonoBehaviour
{
    public void TryAgain()
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
        BehaviourMovement.forwardForce = 400;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
