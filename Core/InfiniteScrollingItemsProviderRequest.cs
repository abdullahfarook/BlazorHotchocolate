namespace BlazorHotchocolate.Core;

public sealed class InfiniteScrollingItemsProviderRequest
{
    public InfiniteScrollingItemsProviderRequest(int startIndex, string search,  CancellationToken cancellationToken)
    {
        StartIndex = startIndex;
        Search = search;
        CancellationToken = cancellationToken;
    }
    public InfiniteScrollingItemsProviderRequest(int startIndex,  CancellationToken cancellationToken)
    {
        StartIndex = startIndex;
        CancellationToken = cancellationToken;
    }

    public int StartIndex { get; }
    public string? Search { get; }

    public CancellationToken CancellationToken { get; }
}