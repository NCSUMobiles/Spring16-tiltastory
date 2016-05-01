using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	
	public void changeToScene (string sceneID) {

        Application.LoadLevel(sceneID);
        
    }
}
