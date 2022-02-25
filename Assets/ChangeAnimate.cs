using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimate : MonoBehaviour
{
  public void getAnimatorRun(){
         this.GetComponent<Animator>().Play("Jog In Circle");
    }
    public void getgetAnimatorJum(){
        this.GetComponent<Animator>().Play("Jump Atta;ck");
    }
}