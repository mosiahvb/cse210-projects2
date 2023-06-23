using System;
public class PromptGenerator
{
    List<string> prompts;  

    public PromptGenerator() 
    {
        prompts = new List<string> // create a new list to be held inside of list-prompts 
        {
            "who made you smile today, and how did they do it? ",
            "what did you learn today that you didnt expect to learn?",
            "how did you make a positive impact on someone's life today?",
            "what did you see when you looked at your family today?",
            "(take a moment) what are you missing in your life, what do you need to do to achieve it?"
        };
    }

    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex= new Random().Next(prompts.Count);                                             
        randomPrompt = prompts[randomIndex];

        return randomPrompt;

    }
}
