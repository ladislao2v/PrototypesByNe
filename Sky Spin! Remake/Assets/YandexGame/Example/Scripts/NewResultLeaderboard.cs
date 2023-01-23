using UnityEngine;
using UnityEngine.UI;

namespace YG.Example
{
    public class NewResultLeaderboard : MonoBehaviour
    {
        [SerializeField] LeaderboardYG leaderboardYG;
        [SerializeField] InputField nameLbInputField;
        [SerializeField] InputField scoreLbInputField;

        // Код для примера! Смена технического названия таблицы и её обновление в компоненте LeaderboardYG
        public void NewName()
        {
            leaderboardYG.nameLB = nameLbInputField.text;
            leaderboardYG.UpdateLB();
        }

        public void NewScore()
        {
            // Статический метод добавление нового рекорда
            YandexGame.NewLeaderboardScores(leaderboardYG.nameLB, int.Parse(scoreLbInputField.text));

            // Метод добавление нового рекорда обращением к компоненту LeaderboardYG
            // leaderboardYG.NewScore(int.Parse(scoreLbInputField.text));
        }
    }
}