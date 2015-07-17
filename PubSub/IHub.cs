using System;

namespace PubSub
{
    internal interface IHub
    {
        void Publish<T>( object sender, T data = default(T) );
        void Subscribe<T>( object sender, Action<T> handler );
        void Unsubscribe( object sender );
        void Unsubscribe<T>( object sender, Action<T> handler = null );
        bool Exists<T>(object sender);
    }
}