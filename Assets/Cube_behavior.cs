using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem; //Pour avoir le nouveau système d'inputs (une fois qu'on a fait créer un fichier C# à l'asset "NewControls"

public class Cube_behavior : MonoBehaviour
{
    public Vector2 Direction; //La variable qui va changer quand on va appuyer sur les boutons
    private Controles Inputs;
    private Rigidbody2D rigidbodyVar; //Variable dans laquelle on mettra le rigidbody
    [SerializeField] float Vitesse; //Variable ajustable pour contrôler la vitesse de déplacement
    [SerializeField] private GameObject projectile; //Variable dans laquelle on peut placer le gameobject projectile
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyVar = GetComponent<Rigidbody2D>();
    }

    // Par convention on met les inputs dans le OnEnable
    private void OnEnable() //La fonction qui implémente les contrôles paramétrés dans Unity
    {
        Inputs = new Controles();
        Inputs.Enable();
        Inputs.CubeMap.Deplacement.performed += Deplacement;
        Inputs.CubeMap.Deplacement.canceled += DeplacementAnnule;
        Inputs.CubeMap.Tirer.performed += Tirer;
    }


    void Deplacement(InputAction.CallbackContext CBC) //La fonction qui incrémente Direction quand on appuie sur les boutons
    {
        Direction = CBC.ReadValue<Vector2>();
    }

    void DeplacementAnnule(InputAction.CallbackContext CBC) //La fonction qui CANCEL quand on relâche un bouton càd elle met Direction à zéro
    {
        Direction = Vector2.zero;
    }

    void Tirer (InputAction.CallbackContext CBC) //La fonction qui instancie le gameobject qu'on a mis dans "projectile"
    {
        Instantiate(projectile, transform.position, transform.rotation); 
    }


    // Update is called once per frame
    void Update()
    {
        rigidbodyVar.AddForce(Direction * Vitesse * Time.deltaTime, ForceMode2D.Impulse); //On applique une force permanente au rigidbody, en fonction de la variable Direction
    }
    //L'utilisation de AddForce pour le déplacement donne une inertie cheloue mais intéressante
}
