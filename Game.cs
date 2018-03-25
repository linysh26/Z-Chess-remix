using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	private int [] state = new int[9];
	private GameObject [] chesses = new GameObject[9];
	private int counter = 0;
	private int turn = 1;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 9; i++)
			this.state [i] = 0;
	}

	void OnGUI(){
		bool result = Judge ();
		if (result) {
			GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 + 50, 200, 100), turn == 1 ? "红先负" : "红先胜");
			if (GUI.Button (new Rect (Screen.width / 2 - 80, Screen.height / 2, 160, 20), "新游戏"))
				this.Restart ();
		}
		else{
			if (counter == 9) {
				GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 + 50, 200, 100), "红先和");
				if (GUI.Button (new Rect (Screen.width / 2 - 80, Screen.height / 2, 160, 20), "新游戏"))
					this.Restart ();
			}
		}
	}

	void Restart(){
		for (int i = 0; i < 9; i++) {
			if (state [i] != 0) {
				Destroy (chesses [i]);
			}
		}

		for (int i = 0; i < 9; i++)
			this.state [i] = 0;
		counter = 0;
		turn = 1;
	}

	bool Judge(){
		for (int i = 0; i < 3; i++) {
			if (state [i] == 0 || state[3 * i] == 0)
				continue;
			if ((state [i] == state [i + 3]) && (state [i] == this.state [i + 6]))
				return true;
			if ((state [3 * i] == state [3 * i + 1]) && (state [3 * i] == state [3 * i + 2]))
				return true;
		}
		if ((state [2] == state [4] && state [2] == state [6] && state[2] != 0)
			|| (state [0] == state [4] && state [0] == state [8] && state[0] != 0))
			return true;
		return false;
	}
	void Register(string name){
		if (Judge ())
			return;
		int x = name [2] - 48;
		int z = name [0] - 48;
		int index = (z - 1) * 3 + x - 1;
		Debug.Log ("Shit(╯‵□′)╯︵┻━┻" + index + " " + turn);
		if (state [index] != 0)
			return;
		switch (turn) {
		case 1:
			chesses [index] = (GameObject)Instantiate (Resources.Load ("chess_1"), new Vector3 ((float)(x - 0.3), (float)1, (float)(z - 0.3)), Quaternion.identity);
			state [index] = turn;
			counter++;
			turn = 2;
			break;
		case 2:
			chesses [index] = (GameObject)Instantiate (Resources.Load ("chess_2"), new Vector3 ((float)(x - 0.3), (float)1, (float)(z - 0.3)), Quaternion.identity);
			state [index] = turn;
			counter++;
			turn = 1;
			break;
		default:
			break;
		}
	}

}
