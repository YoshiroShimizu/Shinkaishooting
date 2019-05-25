using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [System.NonSerialized]
    public int currentStageNum=0;//現在のステージ番号(0始まり)

    [SerializeField]
    string[] stageName;//ステージ名


	// Use this for initialization
	void Start () {
        //シーンを切り替えてもこのゲームオブジェクトを削除しない
        DontDestroyOnLoad(gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //次のステージに進む処理
    public void NextStage(){
        currentStageNum += 1;

        //コルーチンを実行
        StartCoroutine(WaitForLoadScene());
    }

    //シーンの読み込みと待機を行うコルーチン
    IEnumerator WaitForLoadScene()
    {
        //シーンを非同期で読み込みし、読み込まれるまで待機する
        yield return SceneManager.LoadSceneAsync(stageName[currentStageNum]);


    }

    //ゲームオーバー処理
    public void GameOver()
    {

    }

}
