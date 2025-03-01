namespace Haley.Enums {
    public enum RegisterMode {
        /// <summary>
        /// Object state is singleton with in same container. (This can still be resolved as Transient if user needs)
        /// </summary>
        ContainerSingleton,
        /// <summary>
        /// A Weak singleton can be resolved as transient (if user requests). If resolved as registered, it will always return singleton value.
        /// </summary>
        ContainerWeakSingleton,
        /// <summary>
        /// Object state is singleton across all containers. User will not be able to resolve transient. It will always be resolved as singleton. Also, user will not be able to override this value in any child container. The ROOT container holds object with this state.
        /// </summary>
        UniversalSingleton,
        /// <summary>
        /// New instance created on each request (on source container)
        /// </summary>
        Transient,
    }
}
