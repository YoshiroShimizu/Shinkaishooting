using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApperScript : MonoBehaviour {
    //出現させる敵を入れておく
    [SerializeField] GameObject[] enemys;
    //次に敵が出現するまでの時間
    [SerializeField]float apperNextTime;
    //この場所から出現する敵の数
    [SerializeField] int maxNumOfEnemys;
    //今何人の敵を出現させたか
    private int numberOfEnemys;
    //待ち時間計測フィールド
    private float elapseadTime;



	// Use this for initialization
	void Start () {

        numberOfEnemys = 0;
        elapseadTime = 0;

		
	}
	
	// Update is called once per frame
	void Update () {
        //この場所から出現する最大数を超えたら何もしない
        if (numberOfEnemys >= maxNumOfEnemys)
        {
            return;
        }
        elapseadTime += Time.deltaTime;

        //経過時間が経ったら

        if (elapseadTime > apperNextTime) {
            elapseadTime = 0f;

            AppearEnemy();

            
        }		
	}

    void AppearEnemy(){
        //出現させる敵をランダムに選ぶ
        var randomValue = Random.Range(0, enemys.Length);
        //敵の向きをランダムに決定
        var randomRotationY = Random.value * 360f;
        int offsetX = Random.Range(-11, 11);
        int offsetZ = Random.Range(15,19);

        GameObject.Instantiate(enemys[randomValue], transform.position=new Vector3(offsetX,transform.position.y,offsetZ), Quaternion.Euler(0f, randomRotationY, 0f));

        //生成のための参考にした元のスクリプト
        //GameObject.Instantiate(enemys[randomValue], transform.position, Quaternion.Euler(0f, randomRotationY, 0f));

        //生成と生成ポイントを別で設定しようとしたスクリプト
        //GameObject.Instantiate(enemys[randomValue]);
        //enemys.transform.position = new Vector3(enemys.transform.position.x+offsetX,enemys.transform.position.y,enemys.transform.position+offsetZ);

        numberOfEnemys++;
        elapseadTime = 0f;
    }
}
