using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;

// For more information about this template visit http://aka.ms/azurebots-csharp-qnamaker
[Serializable]
public class BasicQnAMakerDialog : QnAMakerDialog
{
    // Go to https://qnamaker.ai and feed data, train & publish your QnA Knowledgebase.
    public BasicQnAMakerDialog() : base(new QnAMakerService(new QnAMakerAttribute(Utils.GetAppSetting("e2e6623f7ddf40cd826f067879b3e897"), Utils.GetAppSetting("cfbcb3a0-97e6-478f-8eba-440640e971ed"))))
    {
    }
}