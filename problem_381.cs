// 381. Insert Delete GetRandom O(1) - Duplicates allowed - https://leetcode.com/problems/insert-delete-getrandom-o1-duplicates-allowed
public class RandomizedCollection {
    private readonly IDictionary<int, HashSet<int>> valueIndex = new Dictionary<int, HashSet<int>>(); 
    private readonly IList<int> values = new List<int>();
    private readonly Random rnd = new Random();

    /** Initialize your data structure here. */
    public RandomizedCollection() { }
    
    /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
    public bool Insert(int val) {
        var contains = valueIndex.ContainsKey(val);
        if (!contains) valueIndex.Add(val, new HashSet<int>());
        values.Add(val);
        valueIndex[val].Add(values.Count - 1);
        return !contains;
    }
    
    /** Removes a value from the collection. Returns true if the collection contained the specified element. */
    public bool Remove(int val) {
        if (!valueIndex.ContainsKey(val)) return false;
        var ix = valueIndex[val].First();
        var lastIx = values.Count - 1;
        if (values.Count > 1) {
            var lastValue = values[lastIx];
            values[ix] = lastValue;
            valueIndex[lastValue].Remove(lastIx);
            if (lastIx != ix) valueIndex[lastValue].Add(ix);
            if (lastValue != val) valueIndex[val].Remove(ix);
        } else {
            valueIndex[val].Remove(ix);
        }
        values.RemoveAt(lastIx);
        if (valueIndex[val].Count == 0) valueIndex.Remove(val);
        return true;
    }
    
    /** Get a random element from the collection. */
    public int GetRandom() {
        return values[rnd.Next(values.Count)];
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */