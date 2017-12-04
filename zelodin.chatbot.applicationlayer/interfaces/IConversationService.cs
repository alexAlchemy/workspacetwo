using zelodin.chatbot.model.interfaces;


namespace zelodin.chatbot.applicationlayer.interfaces
{
    public interface IConversationService
    {
         ICommunicationLever PushStimulus(ICommunicationStimulus stimulus);
    }
}