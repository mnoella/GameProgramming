using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class CharacterMovement : MonoBehaviour
{
    // depalcement gauche droite
    public float speed = 5f;
    public float moveDistance = 5f;
    public float moveDuration = 0.2f;
    public float min = -5f;
    public float max = 5f;
    //public int score = 0;

    void Start()
    {
        
    }

    void Update()
    {
        // deplacement vers l'avant
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //gauche droite
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            MoveLeftRight(-1); 
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            MoveLeftRight(1);


    }


    void MoveLeftRight(int direction)
    {
        Vector3 moveDirection = new Vector3(direction, 0f, 0f);
        Vector3 newPosition = transform.position + moveDirection * moveDistance;

        // Limite min = -5f et max = 5f
        newPosition.x = Mathf.Clamp(newPosition.x, min, max);

        // Nouvelle pos
        transform.position = newPosition;
    }


} 












