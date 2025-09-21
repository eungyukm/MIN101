// using System.Collections;
// using UnityEngine;
//
// public class GameManager : MonoBehaviour
// {
//     private const int time_limit = 6;
//     private int time = 0;
//
//     private const int time_type_limit = 3;
//
//     private enum Time_Type
//     {
//         Night = 0,
//         Dawn = 1,
//         Day = 2,
//         Evenging = 3,
//     }
//
//     private Time_Type current_time = Time_Type.Night;
//     
//     private void Night()
//     {
//         Debug.Log("강아지가 집으로 돌아갑니다.");
//     }
//
//     private void Dawn()
//     {
//         Debug.Log("부지런한 강아지가 광산으로 갑니다.");
//     }
//
//     private void Day()
//     {
//         Debug.Log("강아지가 광산으로 갑니다.");
//     }
//
//     private void Evening()
//     {
//         Debug.Log("개으른 강아지가 집으로 돌아옵니다.");
//     }
//
//     private void Start()
//     {
//         StartCoroutine(GameTimerRoutine());
//     }
//     
//     /// <summary>
//     /// 시간이 time_lit만큼 경과 되면 호출되는 함수
//     /// </summary>
//     private void ChangeTime()
//     {
//         current_time++;
//         if ((int)current_time > time_type_limit)
//         {
//             current_time = Time_Type.Night;
//         }
//
//         switch (current_time)
//         {
//             case Time_Type.Night:
//                 Night();
//                 break;
//             case Time_Type.Dawn:
//                 Dawn();
//                 break;
//             case Time_Type.Day:
//                 Day();
//                 break;
//             case Time_Type.Evenging:
//                 Evening();
//                 break;
//         }
//     }
//
//     private IEnumerator GameTimerRoutine()
//     {
//         while (true)
//         {
//             time++;
//             yield return new WaitForSeconds(1f);
//
//             if (time > time_limit)
//             {
//                 time = 0;
//                 ChangeTime();
//             }
//         }
//     }
// }
