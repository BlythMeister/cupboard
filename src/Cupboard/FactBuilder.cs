namespace Cupboard;

internal sealed class FactBuilder : IFactBuilder
{
    private readonly IReadOnlyList<IFactProvider> _providers;

    public FactBuilder(IEnumerable<IFactProvider> providers)
    {
        _providers = providers.ToReadOnlyList();
    }

    public FactCollection Build(IRemainingArguments args)
    {
        var facts = new FactCollection();
        foreach (var provider in _providers)
        {
            foreach (var (name, value) in provider.GetFacts(args))
            {
                facts.Add(name, value);
            }
        }

        return facts;
    }
}
