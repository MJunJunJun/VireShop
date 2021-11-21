using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class LoginManager : MonoBehaviour
{
    public string namaSceneHome;
    public TMP_InputField player_InputName,player_pasword;
    string username, pasword;
    public int loadScene;

    #region Unity Metyhod
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("coin", 999);
        PlayerPrefs.SetString("username","Muhammad Junaedi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    public void ConnectToPhotonServer()
    {
        if (player_InputName != null)
        {
            username= player_InputName.text;
            pasword = player_pasword.text;
            PlayerPrefs.SetString("username", username);
            PlayerPrefs.SetString("alamat", "Desa Kedondong Rt04/01 Kecamatan Sokaraja, Kabupaten Banyumas");
            SceneManager.LoadScene(loadScene);
            /*getJsonUsername=> ambil data user name
            get data password=>untuk variabel lokal pasword
            jika dapatkan data json user. jika data user== password login
            if(lokal pasword==pasword user di json){
                load scene
            }*/
            /*   PhotonNetwork.NickName = player_InputName.text;
               PhotonNetwork.ConnectUsingSettings();*/
        }
    }

    /*
        #region UI CallBackMethod
        public void ConnectAnonymusly()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public void ConnectToPhotonServer()
        {
            if (player_InputName != null)
            {
                PhotonNetwork.NickName = player_InputName.text;
                PhotonNetwork.ConnectUsingSettings();
            }
        }
        #endregion

        #region Photon Callsbacks Methods
        public override void OnConnected()
        {
            Debug.Log("On Connect is Called,the server is available");
        }
        public override void OnConnectedToMaster()
        {
            Debug.Log("Connect to maseter server with player name: "+PhotonNetwork.NickName);
            PhotonNetwork.LoadLevel(namaSceneHome);
        }

        #endregion


        */

}