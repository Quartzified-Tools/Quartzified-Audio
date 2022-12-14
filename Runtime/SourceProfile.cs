using UnityEngine;

namespace Quartzified.Audio
{
    [CreateAssetMenu(menuName = "Quartzified/Audio/Source Profile", fileName = "New Source Profile")]
    public class SourceProfile : ScriptableObject
    {
        [Tooltip("Seconds before the next sound can play.")]
        [SerializeField] float oneShotDelay;
        public float Delay => oneShotDelay;

        // Random Pitch related settings
        [Tooltip("Can be used for randomized pitch")]
        [SerializeField] Vector2 pitchRange = new Vector2(1f, 1f);
        public Vector2 PitchRange => pitchRange;
        public float LowPitch => PitchRange.x;
        public float HighPitch => PitchRange.y;
    }
}