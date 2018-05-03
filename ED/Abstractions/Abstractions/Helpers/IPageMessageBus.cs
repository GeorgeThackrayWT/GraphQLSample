using System;

namespace EDCORE.Helpers
{
    public interface ISubscriber<in TMessage>
    {
        void HandleMessage(TMessage message);

        string SubscriberId { get; set; }

        DateTime CreatedTime { get; set; }
    }

    public interface IPageMessageBus
    {
        void Subscribe<TMessage>(ISubscriber<TMessage> subscriber);
        void UnSubscribe<TMessage>(ISubscriber<TMessage> subscriber);
        void Publish<TMessage>(TMessage message);

        void Clear();

        void Count();
    }


}