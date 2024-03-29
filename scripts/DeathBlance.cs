using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeathBlance : MonoBehaviour {
    public Text score;
    public Text bureauScore;
    public Text topScore;

    private void OnEnable () {
        bureauScore.text = score.text; //结算本局分数     
        if (PlayerPrefs.HasKey ("分数")) //如果已经存储了分数
            topScore.text = PlayerPrefs.GetString ("分数"); //就获取上次存的最高分数
        //让本局分数和最高分数比较，如果本局分数比最高分数大
        if (Convert.ToInt32 (bureauScore.text) > Convert.ToInt32 (topScore.text)) {
            topScore.text = bureauScore.text; //更新最高分数
            PlayerPrefs.SetString ("分数", bureauScore.text); //存储最高分数        
        }
    }

    public void RestartGame () //重新开始,挂按钮RestartGame上
    {
        SceneManager.LoadScene ("SampleScene"); //加载场景(提前保存一个场景)
    }
    public void QuitGame () //退出游戏,挂按钮QuitGame上
    {
        Application.Quit ();
    }
}