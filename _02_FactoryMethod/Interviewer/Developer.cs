﻿namespace _02_FactoryMethod.Interviewer;

public class Developer : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine("Asking about design patterns!");
    }
}
