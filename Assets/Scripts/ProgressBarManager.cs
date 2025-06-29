using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ProgressBarController : MonoBehaviour
{
    public Slider progressBar;

    void Start()
    {
        // Bắt đầu coroutine để chạy giá trị của progressBar từ 0 đến 100 trong 3 giây.
        StartCoroutine(IncreaseProgressBar());
    }

    IEnumerator IncreaseProgressBar()
    {
        float elapsedTime = 0f;
        float duration = 3f;
        float startValue = 0f;
        float endValue = 100f;

        while (elapsedTime < duration)
        {
            // Tính toán giá trị mới của progressBar dựa trên thời gian đã trôi qua.
            float progressValue = Mathf.Lerp(startValue, endValue, elapsedTime / duration);

            // Đặt giá trị cho progressBar.
            progressBar.value = progressValue;

            // Tăng thời gian đã trôi qua.
            elapsedTime += Time.deltaTime;

            // Chờ một frame tiếp theo.
            yield return null;
        }

        // Đảm bảo giá trị cuối cùng là 100.
        progressBar.value = endValue;
        string nextScene =  PlayerPrefs.GetString("SelectedMap");
        SceneManager.LoadScene(nextScene);
    }
}
