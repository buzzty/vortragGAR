using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthSystem healthSystem;
    [SerializeField] private SpriteSystem spriteSystem;

    private void Death()
    {
        if (healthSystem.health <= 0)
        {
            spriteSystem.playerSpriteRenderer.sprite = spriteSystem.playerSpriteDeath;
        }
    }

    private void Update()
    {
        Death();
    }
}
