using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class Projectile_behavior : MonoBehaviour
{
    private Rigidbody2D rigidbodyVar; //Variable dans laquelle on va mettre le rigidbody
    [SerializeField] float Vitesse; //La vitesse du projectile, ne pas oublier de paramétrer
    [SerializeField] float DureeDeVie; //La durée de vie max du projectile pour ne pas se retrouver avec trop de fois le même objet
    private float Vie; //Variable dans laquelle on va stocker le temps durant lequel le projectile a été actif; quand elle devient égale à DureeDeVie, on détruit l'objet
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbodyVar = GetComponent<Rigidbody2D>(); //On récupère le rigidbody
        rigidbodyVar.AddForce(transform.right * Vitesse, ForceMode2D.Impulse); //On lui applique une impulsion
        Vie += Time.deltaTime;
        //UnityEngine.Debug.Log("Vie: " + Vie); //J'avais ajouté ça car le projectile ne se détruisait pas, mais finalement le script a fonctionné normalement après redémarrage de Unity *emoji hausse les épaules*
        if (Vie >= DureeDeVie) //on vérifie que le projectile n'a pas passé trop de temps actif, si c'est le cas, bye
            {
            Destroy(gameObject);
            }
    }
}
