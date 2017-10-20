// 406. Queue Reconstruction by Height - https://leetcode.com/problems/queue-reconstruction-by-height
public class Solution {
    public int[,] ReconstructQueue(int[,] people) {
        if (people.GetLength(0) == 0) return people;
        var list = new List<Value>();
        for (var i = 0; i < people.GetLength(0); i++) {
            list.Add(new Value(people[i, 0], people[i, 1]));
        }
        list = list.OrderByDescending(x => x.h).ThenBy(x => x.k).ToList();
        for (var i = 1; i < list.Count; i++) {
            var k = list[i].k;
            var j = i;
            while (j > k) {
                list.Swap(j, j - 1);
                j--;
            }
        }
        for (var i = 0; i < list.Count; i++) {
            people[i, 0] = list[i].h;
            people[i, 1] = list[i].k;
        }
        return people;
    }
}

public class Value {
    public int h;
    public int k;
    public Value(int h, int k) {
        this.h = h;
        this.k = k;
    }
}

public static class ListExtensions {
    public static void Swap(this IList<Value> list, int i, int j) {
        var tmp = list[i];
        list[i] = list[j];
        list[j] = tmp;
    }
}