public static class Prompt {
    public static string[] _prompts;
    static Prompt() {
        _prompts = new string[] {
            "Did anything unexpected happen today?",
            "If you had to pick one thing that brought you the most joy today, what would it be?",
            "How did you react to others?",
            "Were there times today when you felt the spirit?",
            "How were you able to progress on your goals?"
            };
    }

    public static string obtainPrompt(){
        return _prompts[new Random().Next(5)];
    }
}