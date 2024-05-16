using SyncfusionBlazorApp.Store.ValueUseCase;

namespace SyncfusionBlazorApp.Store
{
    public record EventValueClicked(string[] Items);
    public record SetValueAction(string[] Items);
    public record LoadValuesFromStorageAction(ValueState storedState);
}
