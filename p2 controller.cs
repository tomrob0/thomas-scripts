using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class p2controller : MonoBehaviour
{
	private Player thePlayer;
	public TextMeshPro tm;
	
    // Start is called before the first frame update
    void Start()
    {
       this.thePlayer = new Player("Tom");
	tm.text = this.thePlayer.getName() + "--> HP: " + this.thePlayer.getHP();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
	this.thePlayer.display();


	/*
       if(MySingleton.player1Turn == false)
	{
      	 print("**player 2: "+ MySingleton.count + "**");
	MySingleton.count++;
	MySingleton.player1Turn = true;
	}
	*/
    }
}
