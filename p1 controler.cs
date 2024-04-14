using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class p1controler : MonoBehaviour
{
	private Player thePlayer;
	public TextMeshPro tm;
	public GameObject destinationGO;
	private float speed = 5.0f;

 	
    // Start is called before the first frame update
    void Start()
    {
      
	this.thePlayer = new Player("John");
	
	tm.text = this.thePlayer.getName() + "--> HP: " + this.thePlayer.getHP();
	this.tm.transform.position = new Vector3(this.transform.position.x+5,
						this.transform.position.y+2,	
						this.transform.position.z);
	
	
    }

    // Update is called once per frame
    private void Update()
    {
	

	this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position,this.destinationGO.transform.position, this.speed * Time.deltaTime);
	
	/*
	if(MySingleton.player1Turn == true)
	{
        print("**player 1: "+ MySingleton.count + "**");
	MySingleton.count++;
	MySingleton.player1Turn = false;
	}
	*/
    }
}
