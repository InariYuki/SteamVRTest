using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class BallManager : MonoBehaviour
{
    [SerializeField] Transform basketBall;
    UIElement spawnBallButton;
    Transform player;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        spawnBallButton = GameObject.Find("SpawnBall").GetComponent<UIElement>();
        spawnBallButton.onHandClick.AddListener(x => basketBall.position = player.position + Vector3.up * 1f + Vector3.forward * 0.2f);
    }
}
