using Fluxor;

namespace SyncfusionBlazorApp.Store.ValueUseCase
{
    [FeatureState]
    public record ValueState(string[] Items)
    {
        public ValueState() : this(new string[0])//default constructor
        {

        }
    }
}
