using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

    //**************課題用コードＳ*************************************
    private AudioSource audioSource;

    //**************課題用コードＥ*************************************

    // Use this for initialization
    void Start()
    {
        //**************課題用コードＳ*************************************
        this.audioSource = this.GetComponent<AudioSource>();
        //**************課題用コードＥ*************************************

    }

    // Update is called once per frame
    void Update()
    {

        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //**************課題用コードＳ*************************************
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "UnityChan") {

            this.audioSource.Play();

        }
    }
    //**************課題用コードＥ*************************************
}