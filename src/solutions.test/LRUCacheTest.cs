namespace solutions.test.easy;
using Shouldly;
using solutions.easy;

/// <summary>
/// https://leetcode.com/problems/lru-cache/
/// </summary>
/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
public class LRUCacheTest
{
    [Fact]
    public void Set112_R12_2()
    {
        //["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
        //[[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
        //=>Output
        //[null, null, null, 1, null, -1, null, -1, 3, 4]

        var lruCache = new LRUCache(2);
        lruCache.Put(1, 1);
        lruCache.Put(2, 2);
        lruCache.Get(1)
            .ShouldBe(1);
        lruCache.Put(3, 3);
        lruCache.Get(2)
            .ShouldBe(-1);
        lruCache.Put(4, 4);
        lruCache.Get(1)
            .ShouldBe(-1);
        lruCache.Get(3)
            .ShouldBe(3);
        lruCache.Get(4)
            .ShouldBe(4);
    }

    [Fact]
    public void Set2()
    {
        //["LRUCache","put","put","get","put","put","get"]
        //[[2],[2,1],[2,2],[2],[1,1],[4,1],[2]]
        //=>Output
        //[null,null,null,2,null,null,-1]

        var lruCache = new LRUCache(2);
        lruCache.Put(2, 1);
        lruCache.Put(2, 2);
        lruCache.Get(2)
            .ShouldBe(2);
        lruCache.Put(1, 1);
        lruCache.Put(4, 1);
        lruCache.Get(2)
            .ShouldBe(-1);
    }
}