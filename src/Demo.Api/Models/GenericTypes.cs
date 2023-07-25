namespace Demo.Api.Models;

public class Response<T>
{
    public T? Data { get; init; }
}
public class Response<T1, T2>
{
    public T1? Data1 { get; init; }
    public T2? Data2 { get; init; }
}
public class ResponseThree<T1, T2, T3>
{
    public T1? Data1 { get; init; }
    public T2? Data2 { get; init; }
    public T3? Data3 { get; init; }
}

public class ListResponse<TData, TMetadata>
    where TMetadata : IMetadata
{
    public TMetadata? Metadata { get; init; }

    public List<TData> Data { get; init; } = new();
}

public class ListSummaryResponse<TData, TMetadata, TSummary>
    where TMetadata : IMetadata
    where TSummary : ITSummary
{
    public TMetadata? Metadata { get; init; }

    public List<TData> Data { get; init; } = new();
    public TSummary? Summary { get; init; }
}

public interface IMetadata { }

public sealed class ListMetadata : IMetadata
{
    public int Count { get; init; }
    public int Total { get; init; }
}


public interface ITSummary { }
public record ListSummary : ITSummary
{
    public string? Message { get; set; }
}

public class ResponseSummary<T> : ITSummary
{
    public T? Data { get; init; }
}
