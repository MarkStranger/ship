using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TractorState { Move, Stop };






public class TractorMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
   // private bool mooving;

    TractorState tractorState = TractorState.Stop;

    void Update()
    {
        if( tractorState == TractorState.Move)
        {
            if (((transform.position.x >= -22f) && (direction == -1f))  || ((transform.position.x <= 22f) && (direction == 1f)))
               
        {
            transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
        }
            //else if ((transform.position.x <= 22f) && (direction == 1f))
            //{
            //    transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            //}
        }



    }

    public void MoveRight()
    {
        
        direction = 1f;
        //mooving = true;
        tractorState = TractorState.Move;
    }
    public void MoveLeft()
    {
        
        direction = -1f;
        // mooving = true;
        tractorState = TractorState.Move;
    }
    public void StopMove()
    {

        //direction = 0f;
        //mooving = false;
        tractorState = TractorState.Stop;
    }

}
