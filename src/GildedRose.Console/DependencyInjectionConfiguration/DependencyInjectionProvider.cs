using GildedRose.Console.BusinessLog;
using GildedRose.Console.Interfaces;
using Unity;

namespace GildedRose.Console.DependencyInjectionConfiguration
{
    public class DependencyInjectionProvider
    {
        private readonly UnityContainer _container;
        public DependencyInjectionProvider()
        {
            _container = RegisterType();
        }

        private UnityContainer RegisterType()
        {
            var container = new UnityContainer();
            container.RegisterType<IGildedRoseManagementSystem, GildedRoseManagementSystem>();
            container.RegisterType<IGildedRoseItem, NormalItem>("NormalItem");
            container.RegisterType<IGildedRoseItem, AgedBrieItem>("AgedBrieItem");
            container.RegisterType<IGildedRoseItem, LegendaryItem>("LegendaryItem");
            container.RegisterType<IGildedRoseItem, BackstagePassesItem>("BackstagePassesItem");
            container.RegisterType<IGildedRoseItem, ConjuredItem>("ConjuredItem");
            return container;
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
