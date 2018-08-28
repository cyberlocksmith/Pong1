//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	public GameObject ball;
	public GameObject scoreGO;
	//public GameObject ballInstance;
	int leftPlayer = 0;
	int rightPlayer = 0;
	public int scoreLimit = 3;
	public KeyCode restartButton;
	bool gameOver = false;

	public Text playerLeftScoreCounter; 
	public Text playerRightScoreCounter;
	public Text playerVictoryText;
	public GameObject gameOverPanel; 
	private score myscore;

	void Start () {
		myscore = (score)scoreGO.GetComponent (typeof(score));
		setBall ();
	}
	

	void Update () {
		//UpdateleftPlayer ();
		//UpdaterightPlayer ();
		if (gameOver == true){
			
		
		if (Input.GetKey(restartButton)) {
			print ("New Game!");
			restartGame ();
			}
		}
	}


	void setBall(){
		//ballInstance = Instantiate (ball);
		//ballInstance.GetComponent<Ball>().gameManager = gameObject.GetComponent<GameManager>();
		}

	public void UpdateleftPlayer (){
		leftPlayer = leftPlayer + 1;
		print ("Left Player Score: " + leftPlayer);
		myscore.UpdateLeftScore(1);
		//Destroy(ballInstance, 1f); 
		ball.transform.position = new Vector3(0,0,0);
		ball.GetComponent<Rigidbody>().velocity = new Vector3 (20, Random.Range(-10f,10f), 0.0f);
		if (leftPlayer == scoreLimit){
			print ("Left Player Has Won");
			print ("Press Spacebar To Restart The Game");
			gameOver = true;
		}
		setBall ();
	}

	public void UpdaterightPlayer (){
		rightPlayer = rightPlayer + 1;
		print ("Right Player Score: " + rightPlayer);
		//Destroy(ballInstance, 1f);
		myscore.UpdateRightScore(1);
		ball.transform.position = new Vector3(0,0,0);
		ball.GetComponent<Rigidbody>().velocity = new Vector3 (-20, Random.Range(-10f,10f), 0.0f);
		if (rightPlayer == scoreLimit){
			print("Right Player Has Won");
			print("Press Spacebar To Restart The Game");
			gameOver = true;
		}
		setBall ();
	}
	void restartGame(){
		string currentScene = SceneManager.GetActiveScene().ToString();
		print (currentScene);
		SceneManager.LoadScene (currentScene);
	}
}