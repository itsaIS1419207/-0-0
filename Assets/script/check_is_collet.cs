using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class check_is_collet : MonoBehaviour
{
        public string scenePaths;



        public hold_asset game_asset;

    // Start is called before the first frame update
  



  public void iscoorect(){

    hold_score.score += 1;
game_asset.correct_clickSound.Play(0);
game_asset.wrong_anim.SetActive(false);

game_asset.canva.SetActive(true);

game_asset.correct_anim.SetActive(true);


    StartCoroutine(WaitForSceneLoad());

Debug.Log("iscorrect");
  }


 public void uncoorect(){

  
game_asset.correct_anim.SetActive(false);
  game_asset.canva.SetActive(true);
  game_asset.wrong_clickSound.Play(0);
game_asset.wrong_anim.SetActive(true);

    StartCoroutine(WaitForSceneLoad());
Debug.Log("uncorrect");

  }

  public void go_to_next_scene(){
            hold_score.score = 0;
  game_asset.next_scene_clickSound.Play(0);

    StartCoroutine(WaitForSceneLoad());
          
Debug.Log("next_scene");


  }



IEnumerator WaitForSceneLoad() {
    yield return new WaitForSeconds(3/2);
          SceneManager.LoadScene(scenePaths);
    
}


}
