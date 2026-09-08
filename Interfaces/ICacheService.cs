
// 27. Cache abstraction
// Rather than putting dictionaries into every service, we'll eventually have one cache abstraction.
// MeatDepartmentFieldGuide.Application/Interfaces/ICacheService.cs

namespace MeatDepartmentFieldGuide.Application.Interfaces;


public interface ICacheService
{
    bool TryGet<T>(
        string key,
        out T? value);


    void Set<T>(
        string key,
        T value,
        TimeSpan? expiration = null);


    void Remove(string key);


    void Clear();
}
