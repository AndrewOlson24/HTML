

public class prompt
{
    list<string> _prompts = new list<string>
    {
        "Who is the coolest person i talked to today?",
        "Best part of the day?",
        "Did you think to pray?",
        "What did you feel today?",
        "Did you learn anything cool today?",
        "Did you remember to do you tasks for today?"

    };

    random_rnd = new Random();

    public prompt()
    {

    }

    public string Get()
    {
        int num = _rnd.Next{_prompts.Count};
        return _prompts[num];

    }
}