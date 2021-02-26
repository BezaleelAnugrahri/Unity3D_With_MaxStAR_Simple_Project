using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ARTrackingSystem
{

    public class GameManager : MonoBehaviour
    {
        #region PUBLIC_VARIABLE
        [Header("UI")]
        public TextMeshPro textName;//character's name for UI
        public TextMeshPro textDesc;//character's description for UI
        public Image iconImage; //character's icon Image for UI

        [Header("OtherClassCall")]
        public Characters[] playableChar;

        public GameObject[] character3D;
        public GameObject[] musicBoxList;

        #endregion

        #region PRIVATE_VARIABLE

        private string trackerName;

        #endregion

        public void Start()
        {

        }

        public void Update()
        {

            trackerName = PlayerPrefs.GetString("TrackerName");

            CharacterDetection(trackerName);

        }

        #region CHARACTER_DETECTOR

        public void CharacterDetection(string trackerName)
        {

            for (int i = 0; i < playableChar.Length; i++)
            {

                if (trackerName == playableChar[i].trackerName)
                {

                    Debug.Log(playableChar[i].trackerName + "," +
                    playableChar[i].name + "," +
                    playableChar[i].charDescription);

                    character3D[i].SetActive(true);
                    musicBoxList[i].SetActive(true);

                }
                else
                {

                    Debug.Log("tracker lost...");
                    character3D[i].SetActive(false);
                    musicBoxList[i].SetActive(false);
                
                }
            
            }


        }

        #endregion

        #region CharacterActionTrigger



        #endregion

        #region NOTE_AND_ADDITIONAL_COMMENT
        /* Input this script inside DefaultTrackableEventHandler.cs if using Vuforia, and QRCodeTrackerSample.cs if using MaxSt
     
        #region EDITING_FUNCTION

        public void ScanningOnTracker(string trackerName)
        {
            //get name of tracker
            PlayerPrefs.SetString("TrackerName", trackerName);
        }

        public void StopScanningTracker()
        {
            PlayerPrefs.SetString("TrackerName", "");
        }

        #endregion // EDITING_FUNCTION
     
         */
        #endregion

    }

}