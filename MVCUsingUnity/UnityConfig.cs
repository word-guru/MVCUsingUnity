using System.Web.Mvc;
using Unity.Mvc5;

namespace MVCUsingUnity
{
    public static class UnityConfig
    {
        public static void RegistrComponents()
        {
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
