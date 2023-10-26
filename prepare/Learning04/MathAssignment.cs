class MathAssignment : Assignment{

    private string _textBookSection = "";
    private string _problems = "";

    public MathAssignment(string studentName, string topic, string bookSection, string problems) : base (studentName, topic){
        _textBookSection = bookSection;
        _problems = problems;
    }

    public string GetMathSummary(){

    return $"Math list:\n{_topic} by {_studentName}, section: {_textBookSection}, problems: {_problems}";

    }
}