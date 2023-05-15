using System;

public class Trigger
{
    public List<string> _prompts = new List<string>() {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Was the food good today?",
            "Where did I go today?",
            "What was the most significant event(s) of the day?",
            "In what way was this day different from other days?",
            "Did I have any significant conversations?",
            "What did I read today? Did it say anything special to me?",
            "How did I feel during the day? What were the high and low points?",
            "Was I worrying about anything today?",
            "What gave me particular happiness or joy today?",
            "What did I accomplish today?",
            "Did I fail at anything and what lesson did I learn?",
            "Did I gain any insights into myself or someone else?"
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        return prompt;
    }
}