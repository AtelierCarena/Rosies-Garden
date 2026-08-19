using System;
using UnityEngine;

namespace RosiesGarden.Core
{
    /// <summary>
    /// Hearts-based health (no death, no hunger/sanity meters — see docs/design/00-overview.md, 1.3).
    /// Losing all hearts should trigger a knockout/relocate flow rather than a fail state; this
    /// component only owns the meter and fires an event other systems (respawn, UI) react to.
    /// </summary>
    public class HeartsHealth : MonoBehaviour
    {
        [SerializeField] private int maxHearts = 5;
        [SerializeField] private int currentHearts;

        public event Action<int, int> HeartsChanged; // (current, max)
        public event Action Knocked;

        private void Awake()
        {
            currentHearts = maxHearts;
        }

        public void TakeDamage(int hearts)
        {
            if (hearts <= 0) return;

            currentHearts = Mathf.Max(0, currentHearts - hearts);
            HeartsChanged?.Invoke(currentHearts, maxHearts);

            if (currentHearts == 0)
            {
                Knocked?.Invoke();
            }
        }

        public void Heal(int hearts)
        {
            if (hearts <= 0) return;

            currentHearts = Mathf.Min(maxHearts, currentHearts + hearts);
            HeartsChanged?.Invoke(currentHearts, maxHearts);
        }
    }
}
