// 380. Insert Delete GetRandom O(1) - https://leetcode.com/problems/insert-delete-getrandom-o1
public class RandomizedSet {
    private readonly IDictionary<int, int> valueIndex = new Dictionary<int, int>(); 
    private readonly IList<int> values = new List<int>();
    private readonly Random rnd = new Random();
    
    /** Initialize your data structure here. */
    public RandomizedSet() { }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if (valueIndex.ContainsKey(val)) return false;
        values.Add(val);
        valueIndex.Add(val, values.Count - 1);
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if (!valueIndex.ContainsKey(val)) return false;
        var ix = valueIndex[val];
        if (values.Count > 1) {
            var lastValue = values[values.Count - 1];
            var lastIx = valueIndex[lastValue];
            valueIndex.Remove(lastValue);
            values[ix] = lastValue;
            valueIndex.Add(lastValue, ix);
        }
        valueIndex.Remove(val);
        values.RemoveAt(values.Count - 1);
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        return values[rnd.Next(values.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */