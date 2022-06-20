using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private  int MaxHEalth;
    private int CurrentHealth;
    private void Start()
    {
        CurrentHealth = MaxHEalth;
    }
    private void ApllyDAmege(int damageValue)
    {
        CurrentHealth -= damageValue;
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
