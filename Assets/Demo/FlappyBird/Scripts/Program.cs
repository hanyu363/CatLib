using System;
using CatLib.API;


namespace CatLib.Demo.FlappyBird
{

	/**
     * 程序启动器 
     */
    public class Bootstraps : IBootstrap
    {

        public void Bootstrap()
        {
            // App.Instance.Register(typeof(EventProvider));
            // App.Instance.Register(typeof(FilterChainProvider));
            // App.Instance.Register(typeof(FilterChainDemo));
        }

    }

	/**
     * 这个类是入口类用于启动框架 
     */
    public class Program : UnityEngine.MonoBehaviour
    {
		public void Awake()
        {
            IApplication application = gameObject.AddComponent<Application>();
            application.Bootstrap(new Type[] { typeof(Bootstraps) }).Init();
        }
    }
}
