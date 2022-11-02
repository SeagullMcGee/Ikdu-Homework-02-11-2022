using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerInfo : MonoBehaviour
{
    public string characterName = "Kevin";
    private int Level = 1;
   
    void Start() 
    {
       Debug.Log (characterName + Level);
    }

  
}
