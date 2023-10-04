using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
    //子オブジェクトのサイズを入れるための変数
    private float Left, Right, Top, Bottom;

    //カメラから見た画面左下の座標を入れる変数
    Vector3 LeftBotton;
    Vector3 RightTop;

    // Start is called before the first frame update
    void Start()
    {
        //子オブジェクトの数だけループ処理を行う
        foreach (Transform child in gameObject.transform)
        {
            //子オブジェクトの中で一番右の位置にいたなら
            if (child.localPosition.x >= Right)
            {
                //子オブジェクトのローカル座標を右端用の変数に代入する
                Right = child.transform.localPosition.x;
            }
            //子オブジェクトの中で一番左にいたら
            if (child.localPosition.x <= Left)
            {
                //子オブジェクトのローカルX座標を左端用の変数に代入する
                Left = child.transform.localPosition.x;
            }
            //子オブジェクトの中で一番上にいたら
            if (child.localPosition.y >= Top)
            {
                //子オブジェクトのローカルy座標を上端用の変数に代入する
                Top = child.transform.localPosition.y;
            }
            //子オブジェクトの中で一番下にいたら
            if (child.localPosition.y <= Bottom)
            {
                //子オブジェクトのローカルy座標を下端用の変数に代入する
                Bottom = child.transform.localPosition.y;
            }
        }

        //カメラとプレイヤーの距離を測る
        var distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        //スクリーン画面左下の位置を設定する
        LeftBotton = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        //スクリーン右上の位置を設定する
        RightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーのワールド座標を取得
        Vector3 pos = transform.position;

        //右矢印キーが押されたとき
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //右方向に0.1動く
            pos.x += 0.1f;
        }
        //左矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //左方向に0.1動く
            pos.x -= 0.1f;
        }
        //上矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //上方向に0.1動く
            pos.y += 0.1f;
        }
        //下矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //下方向に0.1動く
            pos.y -= 0.1f;
        }
        //transform.position = new Vector3(pos.x, pos.y, pos.z);

        //プレイヤーのワールド座標に代入
        transform.position = new Vector3(Mathf.Clamp(pos.x, LeftBotton.x + transform.localScale.x - Left,
            RightTop.x - transform.localScale.x - Right),
            pos.y,
            Mathf.Clamp(pos.z, LeftBotton.z + transform.localScale.z - Bottom,
            RightTop.z - transform.localScale.z - Top));
    }
}
