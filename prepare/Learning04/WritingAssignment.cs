class WritingAssignment : Assignment{

    private string _title = "";

    public WritingAssignment(string studentName, string topic, string title) : base (studentName, topic){
       
        _title = title;
    
    }

    public string GetWritingSummary(){

        return $"Writing list:\nTopic: {_topic} by {_studentName}, Title: {_title} by {_studentName}";

    }

}