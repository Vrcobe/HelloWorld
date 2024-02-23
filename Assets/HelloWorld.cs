using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using clasePlayer;


    public class HelloWorld : MonoBehaviour
    {
        enemy enemy;
        player player;
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Hello world");

            player = new player("MainCharacter");
            enemy = new enemy("Enemy");
            Debug.Log("La vida del enemigo es " + enemy.HealthPoints);
        enemy.TakeDamage();
        Debug.Log("Después de que le hayan atacado, su nueva vida es de " + enemy.HealthPoints);
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("La salud del jugador es de: " + player);
            Debug.Log("El jugador ha eliminado: " + player.getKills());

        }
    }
