using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SlimUI.ModernMenu
{
    public class ExtraLinks : MonoBehaviour
    {
        public GameObject Main;
        public GameObject Extras;
        public GameObject Loading;
        public Slider loadingSlider;
        public void CCP()
        {
            PlayerPrefs.SetString("SelectedMap", "Bridge");
            PlayerPrefs.Save();
            SceneManager.LoadScene("LoadingScene");
        }

        //public void SciFi(){
        //    SceneManager.LoadScene("PickCharacter");
        //}

        public void Clean1()
        {
            PlayerPrefs.SetString("SelectedMap", "BuildingArea");
            PlayerPrefs.Save();
            SceneManager.LoadScene("LoadingScene");
        }

        public void Essence()
        {
            PlayerPrefs.SetString("SelectedMap", "City");
            PlayerPrefs.Save();
            SceneManager.LoadScene("LoadingScene");
        }

    }
}
