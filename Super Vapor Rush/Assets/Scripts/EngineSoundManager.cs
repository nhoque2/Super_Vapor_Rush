using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CarBehaviour
{
    [RequireComponent(typeof(AudioSource))]

    public class EngineSoundManager : MonoBehaviour
    {

        [Header("AudioClips")]
        public AudioClip starting;
        public AudioClip rolling;
        public AudioClip stopping;

        [Header("pitch parameter")]
        public float flatoutSpeed = 20.0f;
        [Range(0.0f, 3.0f)]
        public float minPitch = 0.7f;
        [Range(0.0f, 0.1f)]
        public float pitchSpeed = 0.05f;

        private AudioSource _source;


        void Start()
        {
            _source = GetComponent<AudioSource>();

        }

        void Update()
        {
        }
    }
}
