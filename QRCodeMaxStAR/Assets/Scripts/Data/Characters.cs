using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ARTrackingSystem
{

    [CreateAssetMenu(fileName = "PlayableChar", menuName = "ARCharacter/AddNewCharacter")]
    public class Characters : ScriptableObject
    {
        #region CharacterBiography
        [Header("Character Biography")]

        public string trackerName;//Tracker name == vuforia QRCode/tracker name
        public string charName;//Character Name
        [TextArea(15, 20)]
        public string charDescription;//character Description

        #endregion

        #region CharacterStatus
        [Header("Character Status")]
        //Basic Mode
        public float hp;//Hit Point of your character
        public float mp;//Magic Point of your character
        public int level;//character level
        public float exp;//character exp

        //Battle Mode
        public float attackPower;
        public float defendPower;

        #endregion

        //if 3D
        #region 3DObjectCharacter
        /*[Header("3D Character")]

        [Tooltip("your character3D design (.fbx / .obj / etc that unity supported)")]
        public GameObject char3D;//character 3D design (.fbx / .obj / etc)*/

        #endregion

        //if 2D
        #region 2DObjectCharacter
        [Header("2D Character")]

        public CharacterSprite[] character2DSprites;

        #endregion

        #region CharacterVoiceList

        [Header("CharacterVoiceList")]
        [Tooltip("Input your list character(AudioSources)...")]
        public CharacterAudioSource[] voiceCharacter;
        
        #endregion

    }

    [System.Serializable]
    public class CharacterSprite
    {

        public Sprite faceIcon;

    }

    [System.Serializable]
     public class CharacterAudioSource
     {

         public AudioSource voice;
     
     }

}