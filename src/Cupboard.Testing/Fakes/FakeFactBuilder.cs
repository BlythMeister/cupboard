namespace Cupboard.Testing;

[PublicAPI]
public sealed class FakeFactBuilder : IFactBuilder
{
    public FactCollection Facts { get; set; }

    public FakeFactBuilder()
    {
        Facts = new FactCollection();
    }

    public FactCollection Build(IRemainingArguments args)
    {
        return Facts;
    }
}
