namespace MindfulnessApp.Activities
{
    public class BreathingActivity : Activity{
        public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }


        protected override void ExecuteActivity(int duration, int pauseDuration)
        {
            int elapsed = 0;

            while(elapsed < duration)
            {
                ShowMessage("Breath in...", "");
                CustomPause(pauseDuration);
                elapsed += pauseDuration;

                if (elapsed >= duration) break;
                
                ShowMessage("Breathe out...", "");
                CustomPause(pauseDuration);
                elapsed += pauseDuration;    
            }
        }
    }
}