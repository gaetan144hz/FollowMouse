using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody2D))]
public class SC_FollowMouse : MonoBehaviour
{
    public Vector3 mousePosition;
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;
    public Vector2 wobblePosition = new Vector2(0f, 0f);
    public Vector2 wobbleRotation;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    void Update()
    {
        faceMouse();
        
        mousePosition = Input.mousePosition; //récupère la position de la souris
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        wobblePosition = Vector2.Lerp(transform.position, mousePosition, moveSpeed);//on lerp un vector2 avec la position de la souris
    }

    private void FixedUpdate()
    {
        rb.MovePosition(wobblePosition); //bouge le player
        //clamp la vitesse, avoir une vitesse max sinon suit trop vite la souris lors du respawn
    }

    #region FaceMouse
    public void faceMouse()
    {
        wobbleRotation = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );
        
        transform.up = wobbleRotation;
    }
    #endregion
}
