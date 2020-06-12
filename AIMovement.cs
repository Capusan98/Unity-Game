using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIMovement : MonoBehaviour
{
    public Rigidbody rbp;
    public Text Positiontext;
   // public Transform PlayerBot;

    public float SidewaysForce = 200f;
    public float TimeToMove = 3f;
    public float TimeBetweenMoves = 1.5f;
    public float MoveMargin = 0.5f;
    private float pos;
    public GameObject[] DodgePoint;

    public void TeleportToPosition(float xpos)
    {
       // transform.position.x = xpos;
    }

    public void GetInPosition(float xpos)
    {
        
       
            if (transform.position.x > xpos+ MoveMargin)
                rbp.AddForce(-SidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            if (transform.position.x < xpos- MoveMargin)
                rbp.AddForce(SidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        
    }

    private void Start()
    {
        pos = 0;
        
    }

    public float GetDodgePoint()
    {

        for (int i = 0; i < DodgePoint.Length; i++)
            if (DodgePoint[i].GetComponent<DodgePointCollision>().DodgeThis == 0)
            {
               // Debug.Log(DodgePoint[i].GetComponent<Transform>().position.x);
                Positiontext.text = DodgePoint[i].GetComponent<Transform>().position.x.ToString();
                return DodgePoint[i].GetComponent<Transform>().position.x;
            }
        return 0;
        
    }
    void ResetDodgePoint()
    {
        for (int i = 0; i < DodgePoint.Length; i++)
          DodgePoint[i].GetComponent<DodgePointCollision>().DodgeThis = 0;
    }
    void Update()
    {


        GetInPosition(pos);
      
        
        if (Time.time >= TimeToMove)
        {
            
            pos = GetDodgePoint();

            ResetDodgePoint();
            TimeToMove = Time.time + TimeBetweenMoves;
        }
    }
}
